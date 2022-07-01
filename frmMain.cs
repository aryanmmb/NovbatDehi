using BehComponents;
using NovbatDehi.Class;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NovbatDehi
{
    public partial class FrmMain : RadForm
    {
        public static Setting MySetting;
        public static bool FileSendedToFtp = false;
        private readonly MsgBox _myMessage = new MsgBox();
        private List<Reservations> _firsComeReservationsList = new List<Reservations>();
        private readonly DbManager _myDbManager = new DbManager();
        private List<Reservations> _myReservationsList = new List<Reservations>();
        private List<Reservations> SmsList = new List<Reservations>();
        private readonly DbHelperReservations myDbHelperReservations = new DbHelperReservations();

        public FrmMain()
        {
            InitializeComponent();
            Sms_ResendSms.WorkerReportsProgress = true;
            Sms_ResendSms.WorkerSupportsCancellation = true;
        }

        private void GetSetting()
        {
            var myDbHelperSetting = new DbHelperSetting();
            MySetting = myDbHelperSetting.Get_Setting();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateConection();

            GetSetting();

            _myDbManager.Open_Db();
            CreatTodayReservation();
            RefreshData();
            SendResendSMS();
        }

        private void SendResendSMS()
        {
            try
            {
                if (MySetting.SmsResend)
                {
                    todatedate.Today_Click(null, null);
                    todatedate.NextDay_Click(null, null);
                    SmsList = myDbHelperReservations.Get_All_Reservations(todatedate.Text).Where(x => x.SmsResend == false && x.tozihat == "ثبت شد").ToList();
                    if (SmsList.Count > 0)
                        if (Sms_ResendSms.IsBusy != true)
                        {
                            BtnSendResend.Text = "انصراف";
                            Sms_ResendSms.RunWorkerAsync();
                        }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }


        // This event handler is where the time-consuming work is done.
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            foreach (var item in SmsList)
            {

                if (worker != null && worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    var mycustomer = new DbHelperCustomers().Get_Customer_By_id(item.customer_id);
                    if (mycustomer != null)
                    {
                        var toNum = new string[3];
                        if (mycustomer != null)
                        {
                            if (mycustomer.mobile.Trim() != "") toNum[0] = mycustomer.mobile.Trim();
                            if (mycustomer.mobile2.Trim() != "") toNum[1] = mycustomer.mobile2.Trim();
                            if (mycustomer.mobile3.Trim() != "") toNum[2] = mycustomer.mobile3.Trim();
                        }
                        var flag = SmsHelper.SendSms(item.date, item.time, item.fullname, toNum, SmsType.ReSend);
                        if (flag)
                        {
                            item.SmsResend = true;
                            myDbHelperReservations.Update(item.id, item);
                        }
                        Lb_Progress.Text = "در حال ارسال پیامک";
                    }
                }
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Lb_Progress.Text = (e.ProgressPercentage + "%");
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Lb_Progress.Text = "انصراف";
            }
            else if (e.Error != null)
            {
                Lb_Progress.Text = "خطا: " + e.Error.Message;
            }
            else
            {
                Lb_Progress.Text = "اتمام!";
            }

            BtnSendResend.Text = "ارسال پیام یاد آوری به بیماران فردا";
            Lb_Progress.Text = "ارسال پیامک یادآوری تمام شد";

        }

        private void CreateConection()
        {
            try
            {
                DbManager.StartInstance("MSSQLLocalDB");
                _myDbManager.Open_Db();
                _myDbManager.Close_Db();
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در اتصال به پایگاه داده", MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
                MessageBox.Show(exception.Message);
            }
        }

        private void RefreshData()
        {
            _myReservationsList = myDbHelperReservations.Get_All_Reservations(GetSelectedDatePersianDate())
                .Where(x => x.date.Trim() == GetSelectedDatePersianDate()).ToList();
            DbGrideReserv.AutoGenerateColumns = false;
            DbGrideReserv.DataSource = _myReservationsList;
            LoadFiresComeList();
            RowColor_Update();
        }

        private void RowColor_Update()
        {
            try
            {
                for (var i = 0; i < DbGrideReserv.Rows.Count; i++)
                {
                    var statusPayment = DbGrideReserv.Rows[i].Cells[9].Value.ToString();
                    if (statusPayment == "ثبت شد")
                        DbGrideReserv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(218, 249, 218);
                }
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        private void LoadFiresComeList()
        {
            _firsComeReservationsList = _myReservationsList.Where(x => x.FirstCome.Trim() == "مراجعه اول").ToList();
            DbGrideTodayFirstCom.AutoGenerateColumns = false;
            DbGrideTodayFirstCom.DataSource = _firsComeReservationsList;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   تابع ساخت نوبت ها. </summary>
        /// <remarks>   GK, 07/01/2022. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CreatTodayReservation()
        {
            var flag = true;
            DateTime startTime;
            DateTime.TryParse(MySetting.timeFrom, out startTime);
            DateTime EndTime;
            DateTime.TryParse(MySetting.timeUntil, out EndTime);
            var today = GetSelectedDatePersianDate();
            var reserveList = myDbHelperReservations.Get_All_Reservations(GetSelectedDatePersianDate())
                .Where(x => x.date == today).ToList();
            while (flag)
            {
                if (startTime >= EndTime)
                    flag = false;
                var canbreak = false;
                var tmpNumber =
                    reserveList.Count(x => x.time == startTime.ToString("HH:mm") && x.tozihat != "ثبت نشده");
                var index = reserveList.Count(x => x.time == startTime.ToString("HH:mm"));
                if (index == 0 && tmpNumber == 0)
                    for (var i = 1; canbreak == false; i++)
                    {
                        myDbHelperReservations.Add(new Reservations
                        {
                            date = today,
                            time = startTime.ToString("HH:mm"),
                            tozihat = "ثبت نشده",
                            FirstCome = "",
                            paymentCode = "",
                            paymentKind = "",
                            paymentStatus = "",
                            createTime = DateTime.Now.ToString("HH:mm"),
                            _index = i,
                            note = "...",
                            SmsResend = false
                        });
                        if (i >= MySetting.numberofNovbat)
                            canbreak = true;
                    }
                else if (index == tmpNumber)
                    myDbHelperReservations.Add(new Reservations
                    {
                        date = today,
                        time = startTime.ToString("HH:mm"),
                        tozihat = "ثبت نشده",
                        FirstCome = "",
                        paymentCode = "",
                        paymentKind = "",
                        paymentStatus = "",
                        createTime = DateTime.Now.ToString("HH:mm"),
                        _index = ++index,
                        note = "...",
                        SmsResend = false
                    });

                startTime = startTime.AddMinutes(15);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmAddCustomer().ShowDialog(this);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            new frmGetBimarList().ShowDialog(this);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            new FrmSetting().ShowDialog(this);
            GetSetting();
        }

        private void PersianCalender_DayMouseClick(MonthCalendarX.DayMouseEventArgs e)
        {
            GetSelectedDatePersianDate();
            CreatTodayReservation();
            RefreshData();
        }

        public string GetSelectedDatePersianDate()
        {
            try
            {
                var tmp = PersianCalender.GetSelectedDateInPersianDateTime();
                var s = tmp.Year + "/" + (tmp.Month < 10 ? "0" : "") + tmp.Month + "/" + (tmp.Day < 10 ? "0" : "") +
                        tmp.Day;
                return s;
            }
            catch
            {
                return "0000/00/00";
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            new frmBackupAndReplease().ShowDialog(this);
        }

        private void dataGridViewX1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DbGrideReserv.Rows.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    return;
                }

                if (DbGrideReserv.CurrentRow != null)
                {
                    var rowindex = DbGrideReserv.CurrentRow.Index;
                    var id = DbGrideReserv.Rows[rowindex].Cells[0].Value.ToString();
                    var tmpReservations = _myReservationsList.SingleOrDefault(x => x.id.ToString() == id);
                    if (tmpReservations == null)
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                    }
                    else
                    {
                        var selectedindex = rowindex;
                        var frmAddreserve = new FrmAddReserve();
                        frmAddreserve.MyReservations = tmpReservations;
                        frmAddreserve.ShowDialog(this);
                        tmpReservations = frmAddreserve.MyReservations;
                        myDbHelperReservations.Update(tmpReservations.id, tmpReservations);
                        CreatTodayReservation();
                        RefreshData();

                        DbGrideReserv.Rows[selectedindex].Selected = true;
                    }
                }
            }
            catch
            {
                //
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            try
            {
                var tmpPrintedList = _myReservationsList.Where(x => x.tozihat == "ثبت شد").ToList();
                if (tmpPrintedList.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "امروز هیچ بیماری ندارید!", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    return;
                }

                var index = 1;
                foreach (var item in tmpPrintedList) item._index = index++;

                tmpPrintedList = tmpPrintedList.OrderBy(x => x._index).ToList();
                var tmp = PersianCalender.GetSelectedDateInPersianDateTime();
                var s = tmp.Year + "/" + tmp.Month + "/" + tmp.Day;

                var basePath = Environment.CurrentDirectory;
                var myReport = new StiReport();

                var ReportType = "\\Report\\TodayBimarList.mrt";

                myReport.Load(basePath + ReportType);
                ((StiText)myReport.GetComponentByName("txt1")).Text = s;
                myReport.RegBusinessObject("Reservations", tmpPrintedList);
                myReport.Render();
                myReport.Show();
            }
            catch (Exception exception)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا :" + exception.Message, MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            var x = DbGrideReserv.Width;
            int[] resizeTemplate =
            {
                5 * x / 100, 5 * x / 100, 10 * x / 100,
                10 * x / 100, 10 * x / 100, 15 * x / 100, 15 * x / 100,
                15 * x / 100, 15 * x / 100
            };
            DbGrideReserv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (var i = 0; i < 8; i++)
            {
                DbGrideReserv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DbGrideReserv.Columns[i].Width = resizeTemplate[i];
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            new frmGetReserverReport().ShowDialog(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var path = MySetting.backuppath;
                if (MySetting.AutoBackup)
                {
                    if (path == "")
                        path = "d:/Gksoft/";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    path += "/AutoBackup_" + GetSelectedDatePersianDate().Replace("/", "") + "_" +
                            DateTime.Now.ToString("hhmmss") + ".back";
                    _myDbManager.CreateBackup(path);
                    if (MySetting.AutoSendToFtp)
                        if (General.InternetConected() && !FileSendedToFtp)
                        {
                            e.Cancel = true;
                            var sendfile = new FrmSendFileToFtp();
                            sendfile.BackupFile = path;
                            sendfile.CanExit = true;
                            sendfile.ShowDialog(this);
                        }
                }
            }
            catch (Exception exception)

            {
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در ساخت آپدیت :" + exception.Message, MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
                Console.Write(exception.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbGrideReserv.Rows.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.Ok);
                    _myMessage.ShowDialog();
                    return;
                }

                if (DbGrideReserv.CurrentRow != null)
                {
                    var rowindex = DbGrideReserv.CurrentRow.Index;
                    var id = DbGrideReserv.Rows[rowindex].Cells[0].Value.ToString();
                    var tmpReservations = _myReservationsList.SingleOrDefault(x => x.id.ToString() == id);

                    if (tmpReservations == null)
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.Ok);
                        _myMessage.ShowDialog();
                    }
                    else
                    {
                        var selectedindex = rowindex;

                        tmpReservations.fullname = "...";
                        tmpReservations.tozihat = "ثبت نشده";
                        tmpReservations.customer_id = 0;
                        tmpReservations.note = "...";
                        tmpReservations.mobile = "...";
                        tmpReservations.FirstCome = "...";

                        myDbHelperReservations.Update(tmpReservations.id, tmpReservations);

                        CreatTodayReservation();
                        RefreshData();
                        DbGrideReserv.Rows[selectedindex].Selected = true;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        private void BtnSendResend_Click(object sender, EventArgs e)
        {
            if (SmsList.Count <= 0)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "لیست بیماران فردا خالی است", MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
            }
            else
            if (BtnSendResend.Text == "انصراف")
            {
                if (backgroundWorker1.WorkerSupportsCancellation)
                {
                    BtnSendResend.Text = "ارسال پیام یاد آوری به بیماران فردا";
                    backgroundWorker1.CancelAsync();
                }
            }
            else
            {
                if (Sms_ResendSms.IsBusy != true)
                {
                    BtnSendResend.Text = "انصراف";
                    Sms_ResendSms.RunWorkerAsync();
                }
            }
        }

        private void btnSendStp_Click(object sender, EventArgs e)
        {
            if (General.InternetConected() == false)
            {
                _myMessage.SetMsg(MsgBoxType.Error, "اینترنت متصل نیست", MsgBoxButtonType.Ok);
                _myMessage.ShowDialog();
                return;
            }
            else
            {
                var path = MySetting.backuppath;
                if (MySetting.AutoBackup)
                {
                    if (path == "")
                        path = "d:/Gksoft/";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    path += "/AutoBackup_" + GetSelectedDatePersianDate().Replace("/", "") + "_" +
                            DateTime.Now.ToString("hhmmss") + ".back";
                    _myDbManager.CreateBackup(path);
                }
                var sendfile = new FrmSendFileToFtp();
                sendfile.BackupFile = path;
                sendfile.CanExit = false;
                sendfile.ShowDialog(this);
            }
        }
    }
}