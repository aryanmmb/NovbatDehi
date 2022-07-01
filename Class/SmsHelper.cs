using NovbatDehi.SmsServiceFaraz;
using System;
using System.Linq;
using System.Linq.Dynamic;

namespace NovbatDehi.Class
{
    public enum SmsType
    {
        Reserv,
        ReSend
    }

    public static class SmsHelper
    {
        public static bool SendSms(string date, string time, string name, string[] toNum, SmsType smsType)
        {
            try
            {
                var pattern = smsType == SmsType.Reserv ? FrmMain.MySetting.PaternSend : FrmMain.MySetting.PaternResend;
                var client = new smsserverPortTypeClient();
                var username = FrmMain.MySetting.SmsUsername;
                var password = FrmMain.MySetting.SmsPassword;
                var fromNum = FrmMain.MySetting.SmsLine;
                var data = new[]
                {
                    new input_data_type {key = "name", value = name},
                    new input_data_type {key = "date", value = date},
                    new input_data_type {key = "time", value = time}
                };
                var _toNumm = toNum.Where(c => c != null).ToArray();

                var response = client.sendPatternSms(fromNum, _toNumm, username, password, pattern, data);
                return true;
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return false;
            }
        }
    }
}