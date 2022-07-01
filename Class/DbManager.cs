using MartinCostello.SqlLocalDb;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NovbatDehi.Class
{
    public class DbManager
    {
        private readonly SqlConnection _con;
        private readonly string conestionname = "NovbadConection";

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
            if (_con.State != ConnectionState.Closed)
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
                using (var masterdbConn = new SqlConnection())
                {
                    masterdbConn.ConnectionString = _con.ConnectionString;
                    masterdbConn.Open();
                    using (var multiuserRollbackDbcomm = new SqlCommand())
                    {
                        multiuserRollbackDbcomm.Connection = masterdbConn;
                        multiuserRollbackDbcomm.CommandText = @"ALTER DATABASE " + _con.Database +
                                                              " SET MULTI_USER WITH ROLLBACK IMMEDIATE";

                        multiuserRollbackDbcomm.ExecuteNonQuery();
                    }

                    masterdbConn.Close();
                }

                SqlConnection.ClearAllPools();
                using (var backupConn = new SqlConnection())
                {
                    backupConn.ConnectionString = _con.ConnectionString;
                    backupConn.Open();
                    using (var backupcomm = new SqlCommand())
                    {
                        backupcomm.Connection = backupConn;
                        backupcomm.CommandText = @"BACKUP DATABASE " + _con.Database + " TO DISK='" + filename + "'";
                        backupcomm.ExecuteNonQuery();
                    }

                    backupConn.Close();
                }

                return true;
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return false;
            }
        }

        public bool RestoreBackup(string filename)
        {
            try
            {
                var masterConnectionString = _con.ConnectionString;
                using (var restoreConn = new SqlConnection())
                {
                    restoreConn.ConnectionString = masterConnectionString;
                    restoreConn.Open();
                    using (var multiuserRollbackDbcomm = new SqlCommand())
                    {
                        multiuserRollbackDbcomm.Connection = restoreConn;
                        multiuserRollbackDbcomm.CommandText = @"ALTER DATABASE " + _con.Database +
                                                              " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";

                        multiuserRollbackDbcomm.ExecuteNonQuery();
                    }

                    using (var restoredbExecutioncomm = new SqlCommand())
                    {
                        restoredbExecutioncomm.Connection = restoreConn;
                        restoredbExecutioncomm.CommandText = @"USE MASTER RESTORE DATABASE [" + _con.Database +
                                                             "] FROM DISK='" + filename + "' WITH REPLACE;";
                        restoredbExecutioncomm.ExecuteNonQuery();
                    }

                    restoreConn.Close();
                }

                return true;
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return false;
            }
        }

        /// <summary>
        ///     تابع ساخت و یا اسارت Server
        /// </summary>
        /// <param name="instanceName">نام سرور</param>
        /// <returns></returns>
        public static string StartInstance(string instanceName)
        {
            try
            {
                var localDb = new SqlLocalDbApi();
                var instance = localDb.GetOrCreateInstance(instanceName);
                var manager = instance.Manage();
                if (!instance.IsRunning) manager.Start();
                return "OK";
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return "NO";
            }
        }

        /// <summary>
        ///     تابع توقف   Server
        /// </summary>
        /// <param name="instanceName">نام سرور</param>
        /// <returns></returns>
        public static string StopInstance(string instanceName)
        {
            try
            {
                var localDb = new SqlLocalDbApi();
                var instance = localDb.GetOrCreateInstance(instanceName);
                var manager = instance.Manage();
                if (instance.IsRunning) manager.Stop();
                return "OK";
            }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
            {
                return "NO";
            }
        }
    }

    #endregion DbManager Function
}