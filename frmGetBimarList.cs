using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Dynamic;
using System.Text;
using System.Windows.Forms;
using BarcodeScaner_V2;
using NovbatDehi.Class;
using Telerik.WinControls;
using System.Linq;
namespace NovbatDehi
{
    public partial class frmGetBimarList : Telerik.WinControls.UI.RadForm
    {
        private DbManager _myDbManager = new DbManager();
        private readonly MsgBox _myMessage = new MsgBox();
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        private List<Customer> myCustomers = new List<Customer>();
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
                myCustomers = myDbHelperCustomers.Get_All_Customer();
                DbGrideCustomer.AutoGenerateColumns = false;
                DbGrideCustomer.DataSource = myCustomers;

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
                var tmpCustomer = myCustomers.Where(x => x.code.Contains(_key) || x.mobile.Contains(_key)
                || x.birthDate.Contains(_key) || x.birthDate.Contains(_key) || x.fullname.Contains(_key) || x.id.ToString().Contains(_key)
                || x.bimeCode.Contains(_key) || x.lastUpdate.Contains(_key) || x.mobile2.Contains(_key) || x.mobile3.Contains(_key)
                || x.tozihat.Contains(_key) || x.createTime.Contains(_key));
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
                    MyCustomer = myCustomers.SingleOrDefault(x => x.id.ToString() == id);
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
    }
}
