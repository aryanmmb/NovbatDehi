using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace NovbatDehi.Class
{
    public class DbManager
    {
        private string conestionname = "NovbadConection";
        private readonly SqlConnection _con;
        #region DbManager Function
        public DbManager()
        {

            _con = new SqlConnection(ConfigurationManager.ConnectionStrings[conestionname].ConnectionString);
        }
        public void Open_Db()
        {
            _con.Close();
            _con.Open();
        }
        public void Close_Db()
        {
            if (_con.State != System.Data.ConnectionState.Closed)
                _con.Close();
        }
        public SqlConnection GetConnection_Db()
        {
            return _con;
        }

        public bool CreateBackup(string filename)
        {
            try
            {
                using (SqlConnection masterdbConn = new SqlConnection())
                {
                    masterdbConn.ConnectionString = _con.ConnectionString;
                    masterdbConn.Open();
                    using (SqlCommand multiuserRollbackDbcomm = new SqlCommand())
                    {
                        multiuserRollbackDbcomm.Connection = masterdbConn;
                        multiuserRollbackDbcomm.CommandText = @"ALTER DATABASE " + _con.Database + " SET MULTI_USER WITH ROLLBACK IMMEDIATE";

                        multiuserRollbackDbcomm.ExecuteNonQuery();
                    }
                    masterdbConn.Close();
                }
                SqlConnection.ClearAllPools();
                using (SqlConnection backupConn = new SqlConnection())
                {
                    backupConn.ConnectionString = _con.ConnectionString;
                    backupConn.Open();
                    using (SqlCommand backupcomm = new SqlCommand())
                    {
                        backupcomm.Connection = backupConn;
                        backupcomm.CommandText = @"BACKUP DATABASE " + _con.Database + " TO DISK='" + filename + "'";
                        backupcomm.ExecuteNonQuery();
                    }
                    backupConn.Close();
                }
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
        public bool RestoreBackup(string filename)
        {
            try
            {
                string masterConnectionString = _con.ConnectionString;
                using (SqlConnection restoreConn = new SqlConnection())
                {
                    restoreConn.ConnectionString = masterConnectionString;
                    restoreConn.Open();
                    using (SqlCommand multiuserRollbackDbcomm = new SqlCommand())
                    {
                        multiuserRollbackDbcomm.Connection = restoreConn;
                        multiuserRollbackDbcomm.CommandText = @"ALTER DATABASE " + _con.Database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";

                        multiuserRollbackDbcomm.ExecuteNonQuery();
                    }
                    using (SqlCommand restoredbExecutioncomm = new SqlCommand())
                    {
                        restoredbExecutioncomm.Connection = restoreConn;
                        restoredbExecutioncomm.CommandText = @"USE MASTER RESTORE DATABASE [" + _con.Database + "] FROM DISK='" + filename + "' WITH REPLACE;";
                        restoredbExecutioncomm.ExecuteNonQuery();
                    }
                    restoreConn.Close();
                }
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }


    }
    #endregion



}