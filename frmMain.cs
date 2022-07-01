using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using NovbatDehi.Class;
using System.Linq;
using System.Linq.Dynamic;
using System.Net.PeerToPeer.Collaboration;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeScaner_V2;
using BarcodeScaner_V2.Class;
using BehComponents;
using MoreLinq;
using Stimulsoft.Controls;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace NovbatDehi
{
    public partial class frmMain : Telerik.WinControls.UI.RadForm
    {
        public static Setting MySetting;
        private DbManager _myDbManager = new DbManager();
        private DbHelperReservations myDbHelperReservations = new DbHelperReservations();
        private List<Reservations> myReservationsList = new List<Reservations>();
        private List<Reservations> firsComeReservationsList = new List<Reservations>();
        private readonly MsgBox _myMessage = new MsgBox();
        public static bool FileSendedToFtp = false;

        public frmMain()
        {
            InitializeComponent();

        }

        private void GetSetting()
        {
            DbHelperSetting myDbHelperSetting = new DbHelperSetting();
            MySetting = myDbHelperSetting.Get_Setting();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateConection();

            GetSetting();

            _myDbManager.Open_Db();
            CreatTodayReservation();
            RefreshData();
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
                _myMessage.SetMsg(MsgBoxType.Error, "خطا در اتصال به پایگاه داده", MsgBoxButtonType.OK);
                _myMessage.ShowDialog();
                MessageBox.Show(exception.Message);
            }
        }

        private void RefreshData()
        {
            myReservationsList = myDbHelperReservations.Get_All_Reservations(GetSelectedDatePersianDate())
              .Where(x => x.date.Trim() == GetSelectedDatePersianDate()).ToList();
            DbGrideReserv.AutoGenerateColumns = false;
            DbGrideReserv.DataSource = myReservationsList;
            LoadFiresComeList();
            RowColor_Update();
        }
        private void RowColor_Update()
        {
            try
            {
                for (var i = 0; i < DbGrideReserv.Rows.Count; i++)
                {
                    var id = DbGrideReserv.Rows[i].Cells[0].Value.ToString().ToInt();
                    var statusPayment = DbGrideReserv.Rows[i].Cells[9].Value.ToString();
                    if (statusPayment == "ثبت شد")
                        DbGrideReserv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(218, 249, 218);

                }
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                //
            }
        }

        private void LoadFiresComeList()
        {
            firsComeReservationsList = myReservationsList.Where(x => x.FirstCome.Trim() == "مراجعه اول").ToList();
            DbGrideTodayFirstCom.AutoGenerateColumns = false;
            DbGrideTodayFirstCom.DataSource = firsComeReservationsList;
        }

        /// <summary>
        /// تابع ساخت نوبت ها
        /// </summary>
        private void CreatTodayReservation()
        {
            bool flag = true;
            DateTime startTime;
            DateTime.TryParse(MySetting.timeFrom, out startTime);
            DateTime EndTime;
            DateTime.TryParse(MySetting.timeUntil, out EndTime);
            string today = GetSelectedDatePersianDate();
            var reserveList = myDbHelperReservations.Get_All_Reservations(GetSelectedDatePersianDate()).Where(x => x.date == today).ToList();
            while (flag)
            {
                if (startTime >= EndTime)
                    flag = false;
                bool canbreak = false;
                var tmpNumber = reserveList.Count(x => x.time == startTime.ToString("HH:mm") && x.tozihat != "ثبت نشده");
                int index = reserveList.Count(x => x.time == startTime.ToString("HH:mm"));
                if (index == 0 && tmpNumber == 0)
                {
                    for (int i = 1; canbreak == false; i++)
                    {
                        myDbHelperReservations.Add(new Reservations()
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
                            note = "..."
                        });
                        if (i >= MySetting.numberofNovbat)
                            canbreak = true;
                    }
                }
                else if (index == tmpNumber)
                {
                    myDbHelperReservations.Add(new Reservations()
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
                        note = "..."

                    });
                }

                startTime = startTime.AddMinutes(15);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            new frmAddCustomer().ShowDialog(this);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            new frmGetBimarList().ShowDialog(this);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            new frmSetting().ShowDialog(this);
            GetSetting();
        }

        private void PersianCalender_DayMouseClick(BehComponents.MonthCalendarX.DayMouseEventArgs e)
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
                string s = tmp.Year + "/" + (tmp.Month < 10 ? "0" : "") + tmp.Month + "/" + (tmp.Day < 10 ? "0" : "") + tmp.Day;
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
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }

                if (DbGrideReserv.CurrentRow != null)
                {
                    var rowindex = DbGrideReserv.CurrentRow.Index;
                    var id = DbGrideReserv.Rows[rowindex].Cells[0].Value.ToString();
                    var tmpReservations = myReservationsList.SingleOrDefault(x => x.id.ToString() == id);
                    if (tmpReservations == null)
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        return;
                    }
                    else
                    {
                        int selectedindex = rowindex;
                        frmAddReserve frmAddreserve = new frmAddReserve();
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

            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            try
            {
                var tmpPrintedList = myReservationsList.Where(x => x.tozihat == "ثبت شد").ToList();
                if (tmpPrintedList.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Error, "امروز هیچ بیماری ندارید!", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }

                int index = 1;
                foreach (var item in tmpPrintedList)
                {
                    item._index = index++;
                }

                tmpPrintedList = tmpPrintedList.OrderBy(x => x._index).ToList();
                var tmp = PersianCalender.GetSelectedDateInPersianDateTime();
                string s = tmp.Year + "/" + tmp.Month + "/" + tmp.Day;

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
                _myMessage.SetMsg(MsgBoxType.Error, "خطا :" + exception.Message, MsgBoxButtonType.OK);
                _myMessage.ShowDialog();
                return;
            }
        }


        private void frmMain_Resize(object sender, EventArgs e)
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

        private void buttonX5_Click(object sender, EventArgs e)
        {
            new frmGetReserverReport().ShowDialog(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string path = MySetting.backuppath;
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
                            frmSendFileToFtp sendfile = new frmSendFileToFtp();
                            sendfile.BackupFile = path;
                            sendfile.ShowDialog(this);
                        }


                }
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                MessageBox.Show("خطا در ساخت فایل پشتیبان خودکار");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (General.InternetConected())
            {
                frmSendFileToFtp sendfile = new frmSendFileToFtp();
                sendfile.BackupFile = "D:\\BK\\AutoBackup_14010408040839.back";
                sendfile.ShowDialog(this);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbGrideReserv.Rows.Count <= 0)
                {
                    _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.OK);
                    _myMessage.ShowDialog();
                    return;
                }

                if (DbGrideReserv.CurrentRow != null)
                {
                    var rowindex = DbGrideReserv.CurrentRow.Index;
                    var id = DbGrideReserv.Rows[rowindex].Cells[0].Value.ToString();
                    var tmpReservations = myReservationsList.SingleOrDefault(x => x.id.ToString() == id);

                    if (tmpReservations == null)
                    {
                        _myMessage.SetMsg(MsgBoxType.Information, "سطری برای حذف وجود ندارد!", MsgBoxButtonType.OK);
                        _myMessage.ShowDialog();
                        return;
                    }
                    else
                    {
                        int selectedindex = rowindex;

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
            catch
            {

            }
        }
    }
}
