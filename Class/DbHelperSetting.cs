using System;
using System.Data;
using System.Data.SqlClient;

namespace NovbatDehi.Class
{
    public class DbHelperSetting
    {
        private readonly DbManager _mydb = new DbManager();
        public bool Add(Setting setting)
        {
            try
            {
                _mydb.Open_Db();
                string sql = "INSERT INTO  setting (timeFrom, timeUntil, numberofNovbat, backuppath, emailBackUpSend, AutoBackup,SmsUsername,SmsPassword,SmsLine,PaternResend,PaternSend,EmailPassword,EmailUsername,AutoSendToFtp)" +
                "VALUES(@timeFrom, @timeUntil, @numberofNovbat, @backuppath, @emailBackUpSend, @AutoBackup,@SmsUsername,@SmsPassword,@SmsLine,@PaternResend,@PaternSend,@EmailPassword,@EmailUsername,@AutoSendToFtp)";
                SqlCommand cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AutoBackup", setting.AutoBackup);
                cmd.Parameters.AddWithValue("@backuppath", setting.backuppath);
                cmd.Parameters.AddWithValue("@emailBackUpSend", setting.emailBackUpSend);
                cmd.Parameters.AddWithValue("@numberofNovbat", setting.numberofNovbat);
                cmd.Parameters.AddWithValue("@timeFrom", setting.timeFrom);
                cmd.Parameters.AddWithValue("@timeUntil", setting.timeUntil);
                cmd.Parameters.AddWithValue("@SmsPassword", setting.SmsPassword);
                cmd.Parameters.AddWithValue("@SmsUsername", setting.SmsUsername);
                cmd.Parameters.AddWithValue("@SmsLine", setting.SmsLine);
                cmd.Parameters.AddWithValue("@PaternResend", setting.PaternResend);
                cmd.Parameters.AddWithValue("@PaternSend", setting.PaternSend);
                cmd.Parameters.AddWithValue("@EmailPassword", setting.EmailPassword);
                cmd.Parameters.AddWithValue("@EmailUsername", setting.EmailUsername);
                cmd.Parameters.AddWithValue("@AutoSendToFtp", setting.AutoSendToFtp);

                cmd.ExecuteNonQuery();
                _mydb.Close_Db();
                return true;
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return false;
            }
        }
        public Setting Get_Setting()
        {
            try
            {
                Setting tmpResult = null;
                _mydb.Open_Db();
                SqlCommand cmd = new SqlCommand("select top(1)* from Setting  ", _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tmpResult = new Setting()
                    {
                        AutoBackup = reader["AutoBackup"].ToString().ToBool(),
                        backuppath = reader["backuppath"].ToString(),
                        emailBackUpSend = reader["emailBackUpSend"].ToString(),
                        numberofNovbat = reader["numberofNovbat"].ToString().ToInt(),
                        id = reader["id"].ToString().ToInt(),
                        timeFrom = reader["timeFrom"].ToString(),
                        timeUntil = reader["timeUntil"].ToString(),
                        SmsPassword = reader["SmsPassword"].ToString(),
                        SmsUsername = reader["SmsUsername"].ToString(),
                        SmsLine = reader["SmsLine"].ToString(),
                        PaternResend = reader["PaternResend"].ToString(),
                        PaternSend = reader["PaternSend"].ToString(),
                        EmailPassword = reader["EmailPassword"].ToString(),
                        EmailUsername = reader["EmailUsername"].ToString(),
                        AutoSendToFtp = reader["AutoSendToFtp"].ToString().ToBool(),

                    };
                }
                else
                {
                    var flag = Add(new Setting()
                    {
                        AutoBackup = true,
                        timeFrom = "08:00",
                        timeUntil = "16:00",
                        backuppath = "D:/GksoftBackup",
                        emailBackUpSend = "",
                        numberofNovbat = 3,
                        EmailPassword = "",
                        EmailUsername = "",
                        PaternResend = "",
                        PaternSend = "",
                        SmsLine = "",
                        SmsPassword = "",
                        SmsUsername = ""
                    });
                    if (flag)
                        Get_Setting();
                }
                _mydb.Close_Db();
                return tmpResult;
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return null;
            }
        }
        public bool Update(int settingId, Setting setting)
        {
            try
            {
                _mydb.Open_Db();
                string sql = "UPDATE setting   SET timeFrom = @timeFrom, timeUntil = @timeUntil," +
                " numberofNovbat = @numberofNovbat, backuppath = @backuppath, emailBackUpSend = @emailBackUpSend, AutoBackup = @AutoBackup,SmsPassword=@SmsPassword" + "" +
                ",SmsUsername=@SmsUsername,SmsLine=@SmsLine,PaternResend=@PaternResend,PaternSend=@PaternSend,EmailPassword=@EmailPassword,EmailUsername=@EmailUsername,AutoSendToFtp=@AutoSendToFtp ";
                SqlCommand cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AutoBackup", setting.AutoBackup);
                cmd.Parameters.AddWithValue("@backuppath", setting.backuppath);
                cmd.Parameters.AddWithValue("@emailBackUpSend", setting.emailBackUpSend);
                cmd.Parameters.AddWithValue("@numberofNovbat", setting.numberofNovbat);
                cmd.Parameters.AddWithValue("@timeFrom", setting.timeFrom);
                cmd.Parameters.AddWithValue("@timeUntil", setting.timeUntil);
                cmd.Parameters.AddWithValue("@SmsPassword", setting.SmsPassword);
                cmd.Parameters.AddWithValue("@SmsUsername", setting.SmsUsername);
                cmd.Parameters.AddWithValue("@SmsLine", setting.SmsLine);
                cmd.Parameters.AddWithValue("@PaternResend", setting.PaternResend);
                cmd.Parameters.AddWithValue("@PaternSend", setting.PaternSend);
                cmd.Parameters.AddWithValue("@EmailPassword", setting.EmailPassword);
                cmd.Parameters.AddWithValue("@EmailUsername", setting.EmailUsername);
                cmd.Parameters.AddWithValue("@AutoSendToFtp", setting.AutoSendToFtp);

                cmd.ExecuteNonQuery();
                _mydb.Close_Db();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
