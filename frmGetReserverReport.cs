using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeScaner_V2;
using NovbatDehi.Class;
using Telerik.WinControls;

namespace NovbatDehi
{
    public partial class frmGetReserverReport : Telerik.WinControls.UI.RadForm
    {
        private DbManager _myDbManager = new DbManager();
        private DbHelperReservations myDbHelperReservations = new DbHelperReservations();
        private List<Reservations> myReservationsList = new List<Reservations>();
        private readonly MsgBox _myMessage = new MsgBox();
        public frmGetReserverReport()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            myReservationsList = myDbHelperReservations.Get_All_Reservations().Where(x => x.tozihat == "ثبت شد").ToList();
            RefreshData();
        }
        private void RefreshData()
        {
            try
            {
                string _key = key.Text.Trim();
                var tmpList = myReservationsList.Where(x => x.tozihat.Contains(_key) || x.tozihat.Contains(_key) ||
                                                            x.fullname.Contains(_key) || x.FirstCome.Contains(_key) ||
                                                            x.code.Contains(_key) || x.createTime.Contains(_key) ||
                                                            x.date.Contains(_key)).ToList();
                DbGrideReserv.AutoGenerateColumns = false;
                DbGrideReserv.DataSource = tmpList;
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                DbGrideReserv.AutoGenerateColumns = false;
                DbGrideReserv.DataSource = null;
            }
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DbGrideReserv_Resize(object sender, EventArgs e)
        {
            int x = DbGrideReserv.Width;
            int[] resizeTemplate = { (5 * x) / 100, (5 * x) / 100, (10 * x) / 100,
                (10 * x) / 100, (10 * x) / 100, (15 * x) / 100, (15 * x) / 100,
                (15 * x) / 100,(15 * x) / 100 };
            DbGrideReserv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < 8; i++)
            {
                DbGrideReserv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DbGrideReserv.Columns[i].Width = resizeTemplate[i];
            }
        }
    }
}
