using System;
using System.Collections.Generic;

using NovbatDehi.Class;


namespace NovbatDehi
{
    public partial class frmMain : Telerik.WinControls.UI.RadForm
    {
        private DbManager _myDbManager = new DbManager();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _myDbManager.Open_Db();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            new frmAddCustomer().ShowDialog(this);
        }
    }
}
