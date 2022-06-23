﻿using System;
using System.Windows.Forms;
namespace BarcodeScaner_V2
{
    public partial class MsgBox : Telerik.WinControls.UI.RadForm
    {
        public MsgBox()
        {
            InitializeComponent();
        }
        public void SetMsg(MsgBoxType msgBoxType, string Msg, MsgBoxButtonType msgBoxButtonType)
        {
            btnOK.Visible = false;
            btnNo.Visible = false;
            btnYES.Visible = false;
            Message.Text = Msg;
            Warning.Visible = false;
            Error.Visible = false;
            Confrim.Visible = false;
            Information.Visible = false;
            switch (msgBoxButtonType)
            {
                case MsgBoxButtonType.OK:
                    btnOK.Visible = true;
                    break;
                case MsgBoxButtonType.YESNO:
                    btnNo.Visible = true;
                    btnYES.Visible = true;
                    break;
            }
            switch (msgBoxType)
            {
                case MsgBoxType.Confrim:
                    Confrim.Visible = true;
                    break;
                case MsgBoxType.Error:
                    Error.Visible = true;
                    break;
                case MsgBoxType.Information:
                    Information.Visible = true;
                    break;
                case MsgBoxType.Warning:
                    Warning.Visible = true;
                    break;
            }
        }
        private void btnYES_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}