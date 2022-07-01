using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NovbatDehi.Class;
using Telerik.WinControls;

namespace NovbatDehi
{
    public partial class frmProfileCustomer : Telerik.WinControls.UI.RadForm
    {
        private Customer mycustomer;
        public Reservations MyReservations;
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        public frmProfileCustomer()
        {
            InitializeComponent();
        }

        private void txtBimar_DoubleClick(object sender, EventArgs e)
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
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                //
            }
        }
    }
}
