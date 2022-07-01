using NovbatDehi.Class;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class LoginFom : RadForm
    {
        private readonly MsgBox _myMessage = new MsgBox();

        public LoginFom()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                txtPass.Text = txtPass.Text.Trim();
                txtUname.Text = txtUname.Text.Trim();
                if (txtUname.Text == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "نام کاربری را وارد کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    txtUname.Focus();
                    return;
                }

                if (txtPass.Text == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "رمز عبور را وارد کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    txtPass.Focus();
                }
                //admin myUser = _mydb.admins.SingleOrDefault(x => x.username.Equals(txtUname.Text.Trim()) && x.password.Equals(txtPass.Text));
                //if (myUser != null)
                //{
                //    MainForm.MyAdmin = myUser;
                //    MainForm frmMain = new MainForm();
                //    Hide();
                //    frmMain.Show();
                //}
                //else
                //{
                //    _myMessage.SetMsg(MsgBoxType.Error, "نام کاربری یا رمز عبور اشتباه است", MsgBoxButtonType.OK);
                //    _myMessage.ShowDialog();
                //}
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
                Console.Write(exception.Message);
            }
        }

        private void LoginFom_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Database_Helper.StartInstance("GKSOFT");
            //    _mydb.Database.Connection.Open();
            //    Logger.AddLog("LoginFom LoginFom_Load  ", LogType.Success);
            //}
            //catch (Exception exception)
            //{
            //    Logger.AddLog("LoginFom LoginFom_Load exception:" + exception.Message, LogType.Error);
            //    _myMessage.SetMsg(MsgBoxType.Error, "خطا در اتصال به پایگاه داده", MsgBoxButtonType.OK);
            //    _myMessage.ShowDialog();
            //    MessageBox.Show(exception.Message);
            //}
        }
    }
}