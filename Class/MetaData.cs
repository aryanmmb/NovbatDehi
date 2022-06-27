using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovbatDehi.Class
{
    public class Customer
    {
        public int id { get; set; }
        public string code { get; set; }
        public int kind { get; set; }
        public string fullname { get; set; }
        public string mobile { get; set; }
        public string mobile2 { get; set; }
        public string mobile3 { get; set; }
        public string birthDate { get; set; }
        public string irCode { get; set; }
        public string bimeCode { get; set; }
        public string amount { get; set; }
        public string tozihat { get; set; }
        public string loginCode { get; set; }
        public string loginTime { get; set; }
        public int _try { get; set; }
        public string tryTime { get; set; }
        public string cookie { get; set; }
        public string creatorId { get; set; }
        public int status { get; set; }
        public string lastUpdate { get; set; }
        public string lastActive { get; set; }
        public string userAgent { get; set; }
        public string userIp { get; set; }
        public string createTime { get; set; }
    }

    public class Reservations
    {

        public int _index { get; set; }
        public int id { get; set; }
        public int customer_id { get; set; }
        public string note { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string paymentStatus { get; set; }
        public string paymentKind { get; set; }
        public string paymentCode { get; set; }
        public string createTime { get; set; }
        public string tozihat { get; set; }
        public string FirstCome { get; set; }
        public int Radif { get; set; }
        public string code { get; set; }
        public string fullname { get; set; }
        public string mobile { get; set; }
    }

    public class Setting
    {
        public int id { get; set; }
        public string timeFrom { get; set; }
        public string timeUntil { get; set; }
        public int numberofNovbat { get; set; }
        public string backuppath { get; set; }
        public string emailBackUpSend { get; set; }
        public bool AutoBackup { get; set; }
        public string SmsUsername { get; set; }
        public string SmsPassword { get; set; }
        public string SmsLine { get; set; }
        public string PaternSend { get; set; }
        public string PaternResend { get; set; }


    }
}
