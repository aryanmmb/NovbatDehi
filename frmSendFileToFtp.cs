using Rebex.Net;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class FrmSendFileToFtp : RadForm
    {
        private Thread _backgroundThread;
        private Ftp _ftp;
        private long _remoteOffset;
        private string _remotePath;
        public string BackupFile;
        public bool CanExit;

        public FrmSendFileToFtp()
        {
            InitializeComponent();
        }

        private void StartBackgroundThread(ThreadStart threadStart)
        {
            try
            {
                timer1.Enabled = true;
                lbl_Message.Text = "لطفا صبر کنید ";

                if (_backgroundThread != null)
                {
                    LBLStatus.Text = "خطا در ارسال فایل";
                    timer1.Enabled = false;
                    lbl_Message.Text = "ارسال انجام نشد";
                    return;
                }
                _ftp = new Ftp();
                _ftp.StateChanged += StateChangedProxy;
                _ftp.TransferProgressChanged += TransferProgressProxy;
                _backgroundThread = new Thread(threadStart);
                _backgroundThread.Start();
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void StateChangedProxy(object sender, FtpStateChangedEventArgs e)
        {
            SafeInvoke(new EventHandler<FtpStateChangedEventArgs>(StateChanged), sender, e);
        }

        public void TransferProgressProxy(object sender, FtpTransferProgressChangedEventArgs e)
        {
            SafeInvoke(new EventHandler<FtpTransferProgressChangedEventArgs>(TransferProgress), sender, e);
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

        private void BackgroundUpload()
        {
            Stream local = null;
            try
            {
                local = File.OpenRead(BackupFile);
                var secureMode = SslMode.None;
                _ftp.Settings.SslAcceptAllCertificates = true;
                secureMode = SslMode.Explicit;
                _ftp.Connect(FrmMain.MySetting.emailBackUpSend, 21, secureMode);
                _ftp.Login(FrmMain.MySetting.EmailUsername, FrmMain.MySetting.EmailPassword);
                _remoteOffset = 0;
                _remotePath = Path.GetFileName(BackupFile);
                if (_remoteOffset < local.Length)
                {
                    SetAbortState(true);
                    local.Seek(_remoteOffset, SeekOrigin.Begin);
                    _ftp.PutFile(local, "/backup/" + _remotePath, _remoteOffset, -1);
                }
            }
            catch (FtpException ex)
            {
                LBLStatus.Text = "خطا" + ex.Message;
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

        private void OperationDone()
        {
            try
            {
                pbProgress.Value = 0;
                SetAbortState(false);
                lbl_Message.Text = "ارسال تمام شد";
                timer1.Enabled = false;
                LBLStatus.Text = "اتمام عملیات";
                FrmMain.FileSendedToFtp = true;
                if (CanExit)
                    Application.Exit();
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void SetAbortState(bool enabled)
        {
            if (InvokeRequired) Invoke(new Action<bool>(SetAbortState), enabled);
        }

        private void frmSendFileToFtp_Load(object sender, EventArgs e)
        {
            StartBackgroundThread(BackgroundUpload);
        }

        private delegate void OperationDoneDelegate();

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lbl_Message.Text += ".";
                char ch = '.';
                int freq = lbl_Message.Text.Count(x => (x == ch));
                if (freq > 5)
                    lbl_Message.Text = "لطفا صبر کنید ";
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}