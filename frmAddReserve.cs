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

        private Customer _mycustomer;
        public Reservations MyReservations;
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        private List<Customer> _myCustomers = new List<Customer>();

        public frmAddReserve()
        {
            InitializeComponent();
        }

        private void frmAddReserve_Load(object sender, EventArgs e)
        {
            _myCustomers = myDbHelperCustomers.Get_All_Customer();
            if (MyReservations != null)
            {
                txtBimarCode.Text = MyReservations.fullname == "..." ? "" : MyReservations.fullname;
                lbl_DateTime.Text = MyReservations.date + "/" + MyReservations.time;
                lbl_Mobile.Text = MyReservations.mobile == "..." ? "" : MyReservations.mobile;
                _mycustomer = myDbHelperCustomers.Get_Customer_By_id(MyReservations.customer_id);

                lbl_IrCode.Text = _mycustomer == null ? "ثبت نشده" : _mycustomer.irCode;
                lbl_BimehCode.Text = _mycustomer == null ? "ثبت نشده" : _mycustomer.bimeCode;
                txtNote.Text = MyReservations == null ? "" : MyReservations.note;

            }
        }

        private void key_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{

            //    frmGetBimarList frmGet = new frmGetBimarList();
            //    frmGet.ShowDialog(this);
            //    if (frmGet.MyCustomer != null)
            //    {
            //        mycustomer = frmGet.MyCustomer;
            //        txtBimar.Text = mycustomer.fullname;
            //        lbl_BimehCode.Text = mycustomer.bimeCode;
            //        lbl_IrCode.Text = mycustomer.irCode;
            //        lbl_Mobile.Text = mycustomer.mobile;
            //    }
            //    else
            //    {
            //        txtBimar.Text = "";
            //    }
            //}
            //catch (Exception exception)
            //{
            //    //
            //}
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MyReservations.fullname = _mycustomer == null ? "..." : _mycustomer.fullname;
            MyReservations.tozihat = _mycustomer == null ? "ثبت نشده" : "ثبت شد";
            MyReservations.customer_id = _mycustomer == null ? 0 : _mycustomer.id;
            MyReservations.note = txtNote.Text.Trim() == "" ? "..." : txtNote.Text.Trim();
            MyReservations.mobile = _mycustomer == null ? "..." : _mycustomer.mobile;
            MyReservations.FirstCome = !CheckFirstCome.Checked ? "..." : "مراجعه اول";
            if (checkboxSMS.Checked)
            {
                if (MyReservations.mobile == "..." || MyReservations.mobile == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "برای ارسال پیام حتما باید شماره موبایل ثبت شود", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }

                string[] toNum = new string[3];
                if (_mycustomer != null)
                {
                    if (_mycustomer.mobile.Trim() != "")
                    {
                        toNum[0] = _mycustomer.mobile.Trim();
                    }
                    if (_mycustomer.mobile2.Trim() != "")
                    {
                        toNum[1] = _mycustomer.mobile2.Trim();
                    }
                    if (_mycustomer.mobile3.Trim() != "")
                    {
                        toNum[2] = _mycustomer.mobile3.Trim();
                    }
                }

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


        private void txtBimar_Click(object sender, EventArgs e)
        {
            key_KeyDown(null, null);

        }

        private void txtBimar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBimar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindCustomer();
            }
        }

        private void FindCustomer()
        {
            try
            {
                _mycustomer = _myCustomers.SingleOrDefault(x => x.code == txtBimarCode.Text);
                if (_mycustomer == null)
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "شماره پرونده انتخابی معتبر نیست", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }
                else
                {
                    Lbl_bimarname.Text = _mycustomer.fullname;
                    lbl_BimehCode.Text = _mycustomer.bimeCode;
                    lbl_IrCode.Text = _mycustomer.irCode;
                    lbl_Mobile.Text = _mycustomer.mobile;

                }
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                ///
            }
        }
    }
}
