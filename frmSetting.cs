using NovbatDehi.Class;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class FrmSetting : RadForm
    {
        private readonly DbHelperSetting _myDbHelperSetting = new DbHelperSetting();
        private readonly MsgBox _myMessage = new MsgBox();
        private Setting _mySetting;

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            GetSetting();
        }

        private void GetSetting()
        {
            _mySetting = _myDbHelperSetting.Get_Setting();
            if (_mySetting != null)
            {
                timeFrom.Text = _mySetting.timeFrom;
                timeUntil.Text = _mySetting.timeUntil;
                numberofNovbat.Text = _mySetting.numberofNovbat.ToString();
                CheckAutoBAckup.Checked = _mySetting.AutoBackup;
                AutoSendToFtp.Checked = _mySetting.AutoSendToFtp;
                backupPath.Text = _mySetting.backuppath;
                EmailAddress.Text = _mySetting.emailBackUpSend;
                SmsLine.Text = _mySetting.SmsLine;
                SmsPassword.Text = _mySetting.SmsPassword;
                SmsUsername.Text = _mySetting.SmsUsername;
                PaternResend.Text = _mySetting.PaternResend;
                PaternSend.Text = _mySetting.PaternSend;
                EmailPassword.Text = _mySetting.EmailPassword;
                EmailUsername.Text = _mySetting.EmailUsername;
                SmsResend.Checked = _mySetting.SmsResend;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberofNovbat.Text.ToInt() <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "تعداد نوبت نباید صفر یا کمتر باشد", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    numberofNovbat.Focus();
                    return;
                }

                _mySetting.timeFrom = timeFrom.Text;
                _mySetting.timeUntil = timeUntil.Text;
                _mySetting.numberofNovbat = numberofNovbat.Text.ToInt();
                _mySetting.AutoBackup = CheckAutoBAckup.Checked;
                _mySetting.backuppath = backupPath.Text;
                _mySetting.emailBackUpSend = EmailAddress.Text;
                _mySetting.SmsLine = SmsLine.Text;
                _mySetting.SmsPassword = SmsPassword.Text;
                _mySetting.SmsUsername = SmsUsername.Text;
                _mySetting.PaternResend = PaternResend.Text;
                _mySetting.PaternSend = PaternSend.Text;
                _mySetting.EmailPassword = EmailPassword.Text;
                _mySetting.EmailUsername = EmailUsername.Text;
                _mySetting.AutoSendToFtp = AutoSendToFtp.Checked;
                _mySetting.SmsResend = SmsResend.Checked;

                var flag = _myDbHelperSetting.Update(_mySetting.id, _mySetting);
                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "بروز رسانی با موفقیت انجام شد", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا:" + exception.Message, MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                var folder = new FolderBrowserDialog();
                folder.ShowDialog(this);
                if (folder.SelectedPath != "") backupPath.Text = folder.SelectedPath;
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }
    }
}