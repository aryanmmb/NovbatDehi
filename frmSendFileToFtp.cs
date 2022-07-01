using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebex.IO;
using Rebex.Net;
using Telerik.WinControls;

namespace NovbatDehi
{
    public enum BackgroundOperation
    {
        ConnectFinished,
        LoginFinished,
        GetFileFinished,
        DisconnectFinished,
    }
    public partial class frmSendFileToFtp : Telerik.WinControls.UI.RadForm
    {
        public string BackupFile;
        public frmSendFileToFtp()
        {
            InitializeComponent();
        }
        private Thread _backgroundThread;
        private Ftp _ftp;
        private void StartBackgroundThread(ThreadStart threadStart)
        {
            if (_backgroundThread != null)
            {
                LBLStatus.Text = ("خطا در ارسال فایل");
                return;
            }
            _ftp = new Ftp();
            _ftp.StateChanged += StateChangedProxy;
            _ftp.TransferProgressChanged += TransferProgressProxy;
            _backgroundThread = new Thread(threadStart);
            _backgroundThread.Start();
        }
        private void StateChangedProxy(object sender, FtpStateChangedEventArgs e)
        {
            SafeInvoke(new EventHandler<FtpStateChangedEventArgs>(StateChanged), new object[] { sender, e });
        }

        public void TransferProgressProxy(object sender, FtpTransferProgressChangedEventArgs e)
        {
            SafeInvoke(new EventHandler<FtpTransferProgressChangedEventArgs>(TransferProgress), new object[] { sender, e });
        }
        private void SafeInvoke(Delegate method, params object[] args)
        {
            try
            {
                if (!IsDisposed)
                    Invoke(method, args);
            }
            catch (ObjectDisposedException)
            {
            }
        }
        private void StateChanged(object sender, FtpStateChangedEventArgs e)
        {
            LBLStatus.Text = e.NewState.ToString();
        }

        // This is called on transfer progress
        private void TransferProgress(object sender, FtpTransferProgressChangedEventArgs e)
        {
            pbProgress.Value = Convert.ToInt32(e.CurrentFileProgressPercentage);
            LBLStatus.Text = "در حال انتقال.. " + e.CurrentFileBytesTransferred + " بایت ";
        }
        private long _remoteOffset;
        private string remotePath;

        private void BackgroundUpload()
        {
            Stream local = null;
            try
            {
                local = File.OpenRead(BackupFile);

                SslMode secureMode = SslMode.None;
                _ftp.Settings.SslAcceptAllCertificates = true;
                secureMode = SslMode.Explicit;

                // Connect to the server.
                _ftp.Connect(frmMain.MySetting.emailBackUpSend, 21, secureMode);
                // Log in.
                _ftp.Login(frmMain.MySetting.EmailUsername, frmMain.MySetting.EmailPassword);

                // Get the length of the remote file. This is needed to be able to resume the transfer.

                _remoteOffset = 0;
                remotePath = Path.GetFileName(BackupFile);



                if (_remoteOffset < local.Length)
                {
                    SetAbortState(true);
                    local.Seek(_remoteOffset, SeekOrigin.Begin);
                    _ftp.PutFile(local, "/backup/" + remotePath, _remoteOffset, -1);
                }

            }
            catch (FtpException ex)
            {
                LBLStatus.Text = ("خطا");
            }
            finally
            {
                if (local != null)
                    local.Close();

                _ftp.Disconnect();
                _backgroundThread = null;
                SafeInvoke(new OperationDoneDelegate(OperationDone));
            }

        }
        private delegate void OperationDoneDelegate();

        private void OperationDone()
        {
            // Reset the progress bar
            pbProgress.Value = 0;

            SetAbortState(false);
            LBLStatus.Text = ("ارسال تمام شد");
            frmMain.FileSendedToFtp = true;
            Application.Exit();

        }
        private void SetAbortState(bool enabled)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<bool>(SetAbortState), enabled);
                return;
            }
        }
        private void frmSendFileToFtp_Load(object sender, EventArgs e)
        {
            StartBackgroundThread(BackgroundUpload);
        }
    }
}
