using BarcodeScaner_V2;
using NovbatDehi.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace NovbatDehi
{
    public partial class frmAddCustomer : Telerik.WinControls.UI.RadForm
    {
        private DbManager _myDbManager = new DbManager();
        private readonly MsgBox _myMessage = new MsgBox();
        private DbHelperCustomers myDbHelperCustomers = new DbHelperCustomers();
        private List<Customer> _myCustomers = new List<Customer>();

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
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در دریافت کد پرونده!" + exception.Message,
                    MsgBoxButtonType.OK);
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
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
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
                _myCustomers = myDbHelperCustomers.Get_All_Customer();
                DbGrideCustomer.AutoGenerateColumns = false;
                DbGrideCustomer.DataSource = _myCustomers;
                GetLastCode();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnEdit.Text = "ویرایش";
            }
            catch
            {
                //
            }
        }

        private bool _sortAscending;

        private void DbGrideCustomer_ColumnHeaderMouseClick(object sender,
            System.Windows.Forms.DataGridViewCellMouseEventArgs e)
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
                    var tmpCustomer = _myCustomers.SingleOrDefault(x => x.id.ToString() == id);
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
                                _myMessage.SetMsg(MsgBoxType.Information, "حذف با موفقیت انجام شد",
                                    MsgBoxButtonType.OK);
                                _myMessage.ShowDialog();
                                RefreshAllData();
                            }
                        }
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

        private Customer editedCustomer;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "ویرایش")
                {
                    if (DbGrideCustomer.Rows.Count <= 0)
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "سطری برای ویرایش وجود ندارد!", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        return;
                    }

                    if (DbGrideCustomer.CurrentRow != null)
                    {
                        var rowindex = DbGrideCustomer.CurrentRow.Index;
                        var id = DbGrideCustomer.Rows[rowindex].Cells[0].Value.ToString();
                        editedCustomer = _myCustomers.SingleOrDefault(x => x.id.ToString() == id);
                        if (editedCustomer != null)
                        {
                            txtcode.Text = editedCustomer.code;
                            txtfullname.Text = editedCustomer.fullname;
                            txtbimeCode.Text = editedCustomer.bimeCode;
                            txtbirthDate.Text = editedCustomer.birthDate;
                            txtirCode.Text = editedCustomer.irCode;
                            todatedate.Text = editedCustomer.lastUpdate;
                            txtmobile.Text = editedCustomer.mobile;
                            txtmobile2.Text = editedCustomer.mobile2;
                            txtmobile3.Text = editedCustomer.mobile3;
                            txttozihat.Text = editedCustomer.tozihat;
                            btnEdit.Text = "بروزرسانی";
                            btnAdd.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                        else
                        {
                            _myMessage.SetMsg(MsgBoxType.Information, "بیمار انتخابی شما معتبر نیست ",
                                MsgBoxButtonType.OK);
                            _myMessage.ShowDialog();
                            return;
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
                        if (checkstatus && editedCustomer.code != txtcode.Text)
                        {
                            _myMessage.SetMsg(MsgBoxType.Warning, "کد پرونده تکراری است", MsgBoxButtonType.OK);
                            _myMessage.ShowDialog();
                            txtcode.Focus();
                            return;
                        }
                    }
                    editedCustomer.code = txtcode.Text;
                    editedCustomer.fullname = txtfullname.Text;
                    editedCustomer.bimeCode = txtbimeCode.Text;
                    editedCustomer.birthDate = txtbirthDate.Text;
                    editedCustomer.irCode = txtirCode.Text;
                    editedCustomer.lastUpdate = todatedate.Text;
                    editedCustomer.mobile = txtmobile.Text;
                    editedCustomer.mobile2 = txtmobile2.Text;
                    editedCustomer.mobile3 = txtmobile3.Text;
                    editedCustomer.tozihat = txttozihat.Text;
                    bool flag = myDbHelperCustomers.Update(editedCustomer.id, editedCustomer);
                    if (flag)
                    {
                        _myMessage.SetMsg(MsgBoxType.Confrim, "ویرایش اطلاعات با موفقیت انجام شد", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        ClearInputTextBox();
                        RefreshAllData();
                        return;
                    }
                    else
                    {
                        _myMessage.SetMsg(MsgBoxType.Error, "خطا در ویرایش اطلاعات ورودی ها را چک کنید ", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        return;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_myCustomers.Count <= 0)
            {
                _myMessage.SetMsg(MsgBoxType.Information, "سطری برای چاپ وجود ندارد!", MsgBoxButtonType.OK);
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
            return;
        }
    }
}
