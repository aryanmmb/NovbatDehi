using NovbatDehi.Class;
using System;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class FrmProfileCustomer : RadForm
    {
        private Customer mycustomer;

        public FrmProfileCustomer()
        {
            InitializeComponent();
        }

        private void txtBimar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var frmGet = new frmGetBimarList();
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
                Console.Write(exception.Message);
            }
        }
    }
}