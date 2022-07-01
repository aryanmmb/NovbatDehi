using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovbatDehi.SmsServiceFaraz;
using RestSharp;

namespace NovbatDehi.Class
{
    public enum SmsType
    {
        Reserv, ReSend
    }
    public static class SmsHelper
    {

        public static bool SendSms(string date, string time, string name, string[] toNum, SmsType smsType)
        {
            try
            {
                string pattern = smsType == SmsType.Reserv ? frmMain.MySetting.PaternSend : frmMain.MySetting.PaternResend;
                smsserverPortTypeClient client = new smsserverPortTypeClient();
                var username = frmMain.MySetting.SmsUsername;
                var password = frmMain.MySetting.SmsPassword;
                var fromNum = frmMain.MySetting.SmsLine;
                var data = new input_data_type[] {
                    new input_data_type(){ key ="name",value =name } ,
                    new input_data_type(){ key ="date",value =date },
                    new input_data_type(){ key ="time",value =time }
                };
                var response = client.sendPatternSms(fromNum, toNum, username, password, pattern, data);
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
