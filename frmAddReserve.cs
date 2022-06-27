using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeScaner_V2;
using NovbatDehi.Class;
using Telerik.WinControls;

namespace NovbatDehi
{
    public partial class frmAddReserve : Telerik.WinControls.UI.RadForm
    {
        private readonly MsgBox _myMessage = new MsgBox();

        private Customer mycustomer;
        public Reservations MyReservations;
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        public frmAddReserve()
        {
            InitializeComponent();
        }

        private void frmAddReserve_Load(object sender, EventArgs e)
        {

            if (MyReservations != null)
            {
                txtBimar.Text = MyReservations.fullname == "..." ? "" : MyReservations.fullname;
                lbl_DateTime.Text = MyReservations.date + "/" + MyReservations.time;
                lbl_Mobile.Text = MyReservations.mobile == "..." ? "" : MyReservations.mobile;
                mycustomer = myDbHelperCustomers.Get_Customer_By_id(MyReservations.customer_id);

                lbl_IrCode.Text = mycustomer == null ? "ثبت نشده" : mycustomer.irCode;
                lbl_BimehCode.Text = mycustomer == null ? "ثبت نشده" : mycustomer.bimeCode;

            }
        }

        private void key_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                frmGetBimarList frmGet = new frmGetBimarList();
                frmGet.ShowDialog(this);
                if (frmGet.MyCustomer != null)
                {
                    mycustomer = frmGet.MyCustomer;
                    txtBimar.Text = mycustomer.fullname;
                    lbl_BimehCode.Text = mycustomer.bimeCode;
                    lbl_IrCode.Text = mycustomer.irCode;
                    lbl_Mobile.Text = mycustomer.mobile;
                }
                else
                {
                    txtBimar.Text = "";
                }
            }
            catch (Exception exception)
            {
                //
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MyReservations.fullname = mycustomer == null ? "..." : mycustomer.fullname;
            MyReservations.tozihat = mycustomer == null ? "منقضی" : "ثبت شد";
            MyReservations.customer_id = mycustomer == null ? 0 : mycustomer.id;
            MyReservations.note = txtNote.Text.Trim() == "" ? "..." : txtNote.Text.Trim();
            MyReservations.mobile = mycustomer == null ? "..." : mycustomer.mobile;

            MyReservations.FirstCome = !CheckFirstCome.Checked ? "..." : "مراجعه اول";
            if (checkboxSMS.Checked)
            {
                if (MyReservations.mobile == "..." || MyReservations.mobile == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "برای ارسال پیام حتما باید شماره موبایل ثبت شود", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }

                string[] toNum = { MyReservations.mobile };
                var flag = SmsHelper.SendSms(MyReservations.date, MyReservations.time, MyReservations.fullname, toNum, SmsType.Reserv);
                if (flag == true)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "پیام رزور ارسال شد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();

                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "پیام رزور ارسال نشد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                }
            }

            Close();
        }

        private void txtBimar_DoubleClick(object sender, EventArgs e)
        {
            key_KeyDown(null, null);
        }

        private void txtBimar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
