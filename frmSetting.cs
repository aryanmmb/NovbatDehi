using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeScaner_V2;
using NovbatDehi.Class;
using Telerik.WinControls;

namespace NovbatDehi
{
    public partial class frmSetting : Telerik.WinControls.UI.RadForm
    {
        private Setting MySetting;
        private readonly MsgBox _myMessage = new MsgBox();
        DbHelperSetting myDbHelperSetting = new DbHelperSetting();

        public frmSetting()
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
            MySetting = myDbHelperSetting.Get_Setting();
            if (MySetting != null)
            {
                timeFrom.Text = MySetting.timeFrom;
                timeUntil.Text = MySetting.timeUntil;
                numberofNovbat.Text = MySetting.numberofNovbat.ToString();
                CheckAutoBAckup.Checked = MySetting.AutoBackup;
                backupPath.Text = MySetting.backuppath;
                EmailAddress.Text = MySetting.emailBackUpSend;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberofNovbat.Text.ToInt() <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "تعداد نوبت نباید صفر یا کمتر باشد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    numberofNovbat.Focus();
                    return;
                }
                MySetting.timeFrom = timeFrom.Text;
                MySetting.timeUntil = timeUntil.Text;
                MySetting.numberofNovbat = numberofNovbat.Text.ToInt();
                MySetting.AutoBackup = CheckAutoBAckup.Checked;
                MySetting.backuppath = backupPath.Text;
                MySetting.emailBackUpSend = EmailAddress.Text;

                bool flag = myDbHelperSetting.Update(MySetting.id, MySetting);
                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "بروز رسانی با موفقیت انجام شد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                }

            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا:" + exception.Message, MsgBoxButtonType.OK);
                _myMessage.ShowDialog();
            }
        }
    }
}
