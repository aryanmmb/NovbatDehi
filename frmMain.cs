using System;
using System.Collections.Generic;

using NovbatDehi.Class;
using System.Linq;
using System.Linq.Dynamic;
using System.Net.PeerToPeer.Collaboration;
using System.Windows.Forms;
using BarcodeScaner_V2;
using BehComponents;
using MoreLinq;

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
            DateTime.TryParse("08:00", out startTime);
            DateTime EndTime;
            DateTime.TryParse("16:00", out EndTime);
            string today = GetSelectedDatePersianDate();
            var reserveList = myDbHelperReservations.Get_All_Reservations(GetSelectedDatePersianDate()).Where(x => x.date == today).ToList();
            while (flag)
            {
                if (startTime > EndTime)
                    flag = false;
                bool canbreak = false;
                var tmpNumber = reserveList.Count(x => x.time == startTime.ToString("HH:mm") && x.tozihat != "منقضی");
                int index = reserveList.Count(x => x.time == startTime.ToString("HH:mm"));
                if (index == 0 && tmpNumber == 0)
                {
                    for (int i = 1; canbreak == false; i++)
                    {
                        myDbHelperReservations.Add(new Reservations()
                        {
                            date = today,
                            time = startTime.ToString("HH:mm"),
                            tozihat = "منقضی",
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
                        tozihat = "منقضی",
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

        private void PersianCalender_Load(object sender, EventArgs e)
        {

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
                string s = tmp.Year + "/" + tmp.Month + "/" + tmp.Day;
                return s;
            }
            catch
            {
                return "0000/00/00";
            }
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
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

        private void buttonX4_Click(object sender, EventArgs e)
        {
            new frmBackupAndReplease().ShowDialog(this);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            string[] toNum = { "09188878609" };

            SmsHelper.SendSms("1400/10/10", "08:00", "قباد خلیلی", toNum, SmsType.Reserv);
        }
    }
}
