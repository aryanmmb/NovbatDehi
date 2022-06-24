using BarcodeScaner_V2;
using NovbatDehi.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;


namespace NovbatDehi
{
    public partial class frmAddCustomer : Telerik.WinControls.UI.RadForm
    {
        private DbManager _myDbManager = new DbManager();
        private readonly MsgBox _myMessage = new MsgBox();
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        private List<Customer> myCustomers = new List<Customer>();
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                txtbimeCode.Text = txtbimeCode.Text.Trim();
                txtbirthDate.Text = txtbirthDate.Text.Trim();
                txtcode.Text = txtcode.Text.Trim();
                txtfullname.Text = txtfullname.Text.Trim();
                txtirCode.Text = txtirCode.Text.Trim();
                txtmobile.Text = txtmobile.Text.Trim();
                txtmobile2.Text = txtmobile2.Text.Trim();
                txtmobile3.Text = txtmobile3.Text.Trim();
                txttozihat.Text = txttozihat.Text.Trim();
                if (txtfullname.Text == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Error, " نام بیمار را وارد کنید", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    txtfullname.Focus();
                    return;
                }
                if (txtcode.Text == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "کد پرونده را وارد کنید", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    txtcode.Focus();

                    return;
                }
                if (!checkDuplicateCode.Checked)
                {
                    var checkstatus = myDbHelperCustomers.CheckDuplicate(txtcode.Text);
                    if (checkstatus)
                    {
                        _myMessage.SetMsg(MsgBoxType.Warning, "کد پرونده تکراری است", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        txtcode.Focus();
                        return;
                    }
                }

                bool flag = myDbHelperCustomers.Add(new Customer()
                {
                    code = txtcode.Text,
                    fullname = txtfullname.Text,
                    bimeCode = txtbimeCode.Text,
                    birthDate = txtbirthDate.Text,
                    createTime = DateTime.Now.ToShortTimeString(),
                    irCode = txtirCode.Text,
                    lastUpdate = todatedate.Text,
                    mobile = txtmobile.Text,
                    mobile2 = txtmobile2.Text,
                    mobile3 = txtmobile3.Text,
                    tozihat = txttozihat.Text,
                });


                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Confrim, "ثبت اطلاعات با موفقیت انجام شد", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    ClearInputTextBox();
                    RefreshAllData();
                    return;
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "خطا در ثبت اطلاعات ورودی ها را چک کنید ", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }

            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در ثبت اطلاعات!" + exception.Message, MsgBoxButtonType.OK);
                _myMessage.ShowDialog();
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            try
            {
                GetLastCode();
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در دریافت کد پرونده!" + exception.Message, MsgBoxButtonType.OK);
                _myMessage.ShowDialog();
            }
        }

        private void GetLastCode()
        {
            txtcode.Text = myDbHelperCustomers.GetLastFreeCode().ToString();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                todatedate.Today_Click(null, null);
                GetLastCode();
                RefreshAllData();
            }
            catch (Exception exception)
            {
                //
            }
        }

        private void ClearInputTextBox()
        {
            txtbimeCode.Text = "";
            txtbirthDate.Text = "";
            txtcode.Text = "";
            txtfullname.Text = "";
            txtirCode.Text = "";
            txtmobile.Text = "";
            txtmobile2.Text = "";
            txtmobile3.Text = "";
            txttozihat.Text = "";
        }
        private void RefreshAllData()
        {
            try
            {
                myCustomers = myDbHelperCustomers.Get_All_Customer();
                DbGrideCustomer.AutoGenerateColumns = false;
                DbGrideCustomer.DataSource = myCustomers;
                GetLastCode();
            }
            catch
            {
                //
            }
        }
        private bool _sortAscending;

        private void DbGrideCustomer_ColumnHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (_sortAscending)
                {
                    myCustomers = myCustomers.OrderBy(DbGrideCustomer.Columns[e.ColumnIndex].DataPropertyName).ToList();
                    DbGrideCustomer.DataSource = myCustomers;
                }
                else
                {
                    myCustomers = myCustomers.OrderBy(DbGrideCustomer.Columns[e.ColumnIndex].DataPropertyName).Reverse()
                        .ToList();
                    DbGrideCustomer.DataSource = myCustomers;
                }
                _sortAscending = !_sortAscending;

            }
            catch (Exception exception)
            {
                //
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbGrideCustomer.Rows.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }
                if (DbGrideCustomer.CurrentRow != null)
                {
                    var rowindex = DbGrideCustomer.CurrentRow.Index;
                    var id = DbGrideCustomer.Rows[rowindex].Cells[0].Value.ToString();
                    var tmpCustomer = myCustomers.SingleOrDefault(x => x.id.ToString() == id);
                    if (tmpCustomer != null)
                    {
                        _myMessage.SetMsg(MsgBoxType.Error,
                            " از حذف  بیمار  با نام " + tmpCustomer.fullname + " اطمینان دارید؟ ",
                            MsgBoxButtonType.YESNO);
                        var tmpResult = _myMessage.ShowDialog();
                        if (tmpResult == DialogResult.Yes)
                        {
                            var deleteResult = myDbHelperCustomers.Delete(tmpCustomer.id);
                            if (deleteResult)
                            {
                                _myMessage.SetMsg(MsgBoxType.Information, "حذف با موفقیت انجام شد" , MsgBoxButtonType.OK);
                                _myMessage.ShowDialog();
                                RefreshAllData();
                            }
                        }
                    }
                    else
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "بیمار انتخابی شما معتبر نیست " , MsgBoxButtonType.OK);
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
