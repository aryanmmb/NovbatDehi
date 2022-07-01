using NovbatDehi.Class;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class FrmAddCustomer : RadForm
    {
        private readonly DbHelperCustomers _myDbHelperCustomers = new DbHelperCustomers();
        private readonly MsgBox _myMessage = new MsgBox();

        private Customer _editedCustomer;
        private List<Customer> _myCustomers = new List<Customer>();

        private bool _sortAscending;

        public FrmAddCustomer()
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
                    _myMessage.SetMsg(MsgBoxType.Error, " نام بیمار را وارد کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    txtfullname.Focus();
                    return;
                }

                if (txtcode.Text == "")
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "کد پرونده را وارد کنید", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    txtcode.Focus();

                    return;
                }

                if (!checkDuplicateCode.Checked)
                {
                    var checkstatus = _myDbHelperCustomers.CheckDuplicate(txtcode.Text);
                    if (checkstatus)
                    {
                        _myMessage.SetMsg(MsgBoxType.Warning, "کد پرونده تکراری است", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                        txtcode.Focus();
                        return;
                    }
                }

                var flag = _myDbHelperCustomers.Add(new Customer
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
                    tozihat = txttozihat.Text
                });

                if (flag)
                {
                    _myMessage.SetMsg(MsgBoxType.Confrim, "ثبت اطلاعات با موفقیت انجام شد", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    ClearInputTextBox();
                    RefreshAllData();
                }
                else
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "خطا در ثبت اطلاعات ورودی ها را چک کنید ", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در ثبت اطلاعات!" + exception.Message, MsgBoxButtonType.Ok);
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
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در دریافت کد پرونده!" + exception.Message,
                    MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
            }
        }

        private void GetLastCode()
        {
            txtcode.Text = _myDbHelperCustomers.GetLastFreeCode().ToString();
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
                Console.Write(exception.Message);
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
                _myCustomers = _myDbHelperCustomers.Get_All_Customer();
                DbGrideCustomer.AutoGenerateColumns = false;
                DbGrideCustomer.DataSource = _myCustomers;
                GetLastCode();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnEdit.Text = "ویرایش";
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        private void DbGrideCustomer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (_sortAscending)
                {
                    _myCustomers = _myCustomers.OrderBy(DbGrideCustomer.Columns[e.ColumnIndex].DataPropertyName)
                        .ToList();
                    DbGrideCustomer.DataSource = _myCustomers;
                }
                else
                {
                    _myCustomers = _myCustomers.OrderBy(DbGrideCustomer.Columns[e.ColumnIndex].DataPropertyName)
                        .Reverse()
                        .ToList();
                    DbGrideCustomer.DataSource = _myCustomers;
                }

                _sortAscending = !_sortAscending;
            }
            catch (Exception exception)

            {
                Console.Write(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbGrideCustomer.Rows.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    return;
                }

                if (DbGrideCustomer.CurrentRow != null)
                {
                    var rowindex = DbGrideCustomer.CurrentRow.Index;
                    var id = DbGrideCustomer.Rows[rowindex].Cells[0].Value.ToString();
                    var tmpCustomer = _myCustomers.SingleOrDefault(x => x.id.ToString() == id);
                    if (tmpCustomer != null)
                    {
                        _myMessage.SetMsg(MsgBoxType.Error,
                            " از حذف  بیمار  با نام " + tmpCustomer.fullname + " اطمینان دارید؟ ",
                            MsgBoxButtonType.Yesno);
                        var tmpResult = _myMessage.ShowDialog();
                        if (tmpResult == DialogResult.Yes)
                        {
                            var deleteResult = _myDbHelperCustomers.Delete(tmpCustomer.id);
                            if (deleteResult)
                            {
                                _myMessage.SetMsg(MsgBoxType.Information, "حذف با موفقیت انجام شد",
                                    MsgBoxButtonType.Ok);
                                _myMessage.ShowDialog();
                                RefreshAllData();
                            }
                        }
                    }
                    else
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "بیمار انتخابی شما معتبر نیست ", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Information, "خطایی رخ داده:" + exception.Message, MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
                Console.Write(exception.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "ویرایش")
                {
                    if (DbGrideCustomer.Rows.Count <= 0)
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "سطری برای ویرایش وجود ندارد!", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                        return;
                    }

                    if (DbGrideCustomer.CurrentRow != null)
                    {
                        var rowindex = DbGrideCustomer.CurrentRow.Index;
                        var id = DbGrideCustomer.Rows[rowindex].Cells[0].Value.ToString();
                        _editedCustomer = _myCustomers.SingleOrDefault(x => x.id.ToString() == id);
                        if (_editedCustomer != null)
                        {
                            txtcode.Text = _editedCustomer.code;
                            txtfullname.Text = _editedCustomer.fullname;
                            txtbimeCode.Text = _editedCustomer.bimeCode;
                            txtbirthDate.Text = _editedCustomer.birthDate;
                            txtirCode.Text = _editedCustomer.irCode;
                            todatedate.Text = _editedCustomer.lastUpdate;
                            txtmobile.Text = _editedCustomer.mobile;
                            txtmobile2.Text = _editedCustomer.mobile2;
                            txtmobile3.Text = _editedCustomer.mobile3;
                            txttozihat.Text = _editedCustomer.tozihat;
                            btnEdit.Text = "بروزرسانی";
                            btnAdd.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                        else
                        {
                            _myMessage.SetMsg(MsgBoxType.Information, "بیمار انتخابی شما معتبر نیست ",
                                MsgBoxButtonType.Ok);
                            _myMessage.ShowDialog();
                        }
                    }
                }
                else
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
                        _myMessage.SetMsg(MsgBoxType.Error, " نام بیمار را وارد کنید", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                        txtfullname.Focus();
                        return;
                    }

                    if (txtcode.Text == "")
                    {
                        _myMessage.SetMsg(MsgBoxType.Error, "کد پرونده را وارد کنید", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                        txtcode.Focus();

                        return;
                    }

                    if (!checkDuplicateCode.Checked)
                    {
                        var checkstatus = _myDbHelperCustomers.CheckDuplicate(txtcode.Text);
                        if (checkstatus && _editedCustomer.code != txtcode.Text)
                        {
                            _myMessage.SetMsg(MsgBoxType.Warning, "کد پرونده تکراری است", MsgBoxButtonType.Ok);
                            _myMessage.ShowDialog();
                            txtcode.Focus();
                            return;
                        }
                    }

                    _editedCustomer.code = txtcode.Text;
                    _editedCustomer.fullname = txtfullname.Text;
                    _editedCustomer.bimeCode = txtbimeCode.Text;
                    _editedCustomer.birthDate = txtbirthDate.Text;
                    _editedCustomer.irCode = txtirCode.Text;
                    _editedCustomer.lastUpdate = todatedate.Text;
                    _editedCustomer.mobile = txtmobile.Text;
                    _editedCustomer.mobile2 = txtmobile2.Text;
                    _editedCustomer.mobile3 = txtmobile3.Text;
                    _editedCustomer.tozihat = txttozihat.Text;
                    var flag = _myDbHelperCustomers.Update(_editedCustomer.id, _editedCustomer);
                    if (flag)
                    {
                        _myMessage.SetMsg(MsgBoxType.Confrim, "ویرایش اطلاعات با موفقیت انجام شد", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                        ClearInputTextBox();
                        RefreshAllData();
                    }
                    else
                    {
                        _myMessage.SetMsg(MsgBoxType.Error, "خطا در ویرایش اطلاعات ورودی ها را چک کنید ",
                            MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (_myCustomers.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای چاپ وجود ندارد!", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    return;
                }

                var basePath = Environment.CurrentDirectory;
                var myReport = new StiReport();
                var ReportType = "\\Report\\Report.mrt";
                myReport.Load(basePath + ReportType);
                myReport.RegBusinessObject("Customer", _myCustomers);
                myReport.Render();
                myReport.Show();
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }
    }
}