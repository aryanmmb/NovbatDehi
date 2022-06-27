using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BarcodeScaner_V2;
using NovbatDehi.Class;
using Telerik.WinControls;

namespace NovbatDehi
{
    public partial class frmBackupAndReplease : Telerik.WinControls.UI.RadForm
    {
        private readonly MsgBox _myMessage = new MsgBox();

        private DbManager myDbManager = new DbManager();
        public frmBackupAndReplease()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Database_Novbat_" + DateTime.Now.ToString("yyyyMMdd") + ".back";
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != ""  )
            {
                bool flag = myDbManager.CreateBackup(saveFileDialog1.FileName);
                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "پشتیبان گیری با موفقیت انجام شد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();

                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            if (openFileDialog1.FileName != "" && File.Exists(openFileDialog1.FileName))
            {
                bool flag = myDbManager.RestoreBackup(openFileDialog1.FileName);
                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "بازیابی پشتیبان با موفقیت انجام شد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();

                    _myMessage.SetMsg(MsgBoxType.Information, "برنامه را دوباره باز کنید", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "خطایی رخ داده ورودی ها را چک کنید", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                }
            }
        }
    }
}
