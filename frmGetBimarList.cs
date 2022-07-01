using System;
using System.Collections.Generic;
using System.Linq.Dynamic;
using System.Windows.Forms;
using BarcodeScaner_V2;
using NovbatDehi.Class;
using System.Linq;
namespace NovbatDehi
{
    public partial class frmGetBimarList : Telerik.WinControls.UI.RadForm
    {
        private DbManager _myDbManager = new DbManager();
        private readonly MsgBox _myMessage = new MsgBox();
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        private List<Customer> _myCustomers = new List<Customer>();
        public Customer MyCustomer;
        public frmGetBimarList()
        {
            InitializeComponent();
        }

        private void frmGetBimarList_Load(object sender, EventArgs e)
        {
            RefreshAllData();
        }
        private void RefreshAllData()
        {
            try
            {
                _myCustomers = myDbHelperCustomers.Get_All_Customer().ToList();
                DbGrideCustomer.AutoGenerateColumns = false;
                DbGrideCustomer.DataSource = _myCustomers;

            }
            catch
            {
                //
            }
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string _key = key.Text.Trim();
                var tmpCustomer = _myCustomers.Where(x => x.code.Contains(_key) || x.mobile.Contains(_key)
                || x.birthDate.Contains(_key) || x.birthDate.Contains(_key) || x.fullname.Contains(_key) || x.id.ToString().Contains(_key)
                || x.bimeCode.Contains(_key) || x.lastUpdate.Contains(_key) || x.mobile2.Contains(_key) || x.mobile3.Contains(_key)
                || x.tozihat.Contains(_key) || x.createTime.Contains(_key)).ToList();
                DbGrideCustomer.AutoGenerateColumns = false;
                DbGrideCustomer.DataSource = tmpCustomer;
            }
            catch
            {
                //
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbGrideCustomer.Rows.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای انتخاب وجود ندارد!", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }
                if (DbGrideCustomer.CurrentRow != null)
                {
                    var rowindex = DbGrideCustomer.CurrentRow.Index;
                    var id = DbGrideCustomer.Rows[rowindex].Cells[0].Value.ToString();
                    MyCustomer = _myCustomers.SingleOrDefault(x => x.id.ToString() == id);
                    if (MyCustomer != null)
                    {
                        Close();
                    }
                    else
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "بیمار انتخابی شما معتبر نیست ", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        return;
                    }
                }
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Information, "خطایی رخ داده:" + exception.Message, MsgBoxButtonType.OK);
                _myMessage.ShowDialog();
            }
        }

        private void DbGrideCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonX1_Click(null, null);
        }
        private bool _sortAscending;
        private void DbGrideCustomer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (_sortAscending)
                {
                    _myCustomers = _myCustomers.OrderBy(DbGrideCustomer.Columns[e.ColumnIndex].DataPropertyName).ToList();
                    DbGrideCustomer.DataSource = _myCustomers;
                }
                else
                {
                    _myCustomers = _myCustomers.OrderBy(DbGrideCustomer.Columns[e.ColumnIndex].DataPropertyName).Reverse()
                        .ToList();
                    DbGrideCustomer.DataSource = _myCustomers;
                }
                _sortAscending = !_sortAscending;

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
