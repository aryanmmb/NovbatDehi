using NovbatDehi.Class;
using System;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class frmBackupAndReplease : RadForm
    {
        private readonly MsgBox _myMessage = new MsgBox();

        private readonly DbManager _myDbManager = new DbManager();

        public frmBackupAndReplease()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Database_Novbat_" + DateTime.Now.ToString("yyyyMMdd") + ".back";
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != "")
            {
                var flag = _myDbManager.CreateBackup(saveFileDialog1.FileName);
                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "پشتیبان گیری با موفقیت انجام شد", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            if (openFileDialog1.FileName != "" && File.Exists(openFileDialog1.FileName))
            {
                var flag = _myDbManager.RestoreBackup(openFileDialog1.FileName);
                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "بازیابی پشتیبان با موفقیت انجام شد",
                        MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();

                    _myMessage.SetMsg(MsgBoxType.Information, "برنامه را دوباره باز کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                }
            }
        }
    }
}