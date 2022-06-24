using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
        public int FindBigestNumber(string tablename)
        {
            SqlConnection localConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[conestionname].ConnectionString);
            try
            {
                if (localConnection.State == ConnectionState.Open)
                    localConnection.Close();
                localConnection.Open();
                SqlCommand cmd = new SqlCommand("FindMaxId", localConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("tablename", tablename);
                SqlDataReader reader = cmd.ExecuteReader();
                int maxid = -1;
                if (reader.Read())
                {
                    maxid = int.Parse(reader["maxid"].ToString());
                }
                localConnection.Close();
                return maxid;
            }
            catch (Exception exception)
            {
                localConnection.Close();
                return -1;
            }
        }
        public int FindBigestFactorForCustomer(int customerId)
        {
            try
            {
                Open_Db();
                SqlCommand cmd = new SqlCommand("FindMaxFactorId", _con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("customerId", customerId);
                SqlDataReader reader = cmd.ExecuteReader();
                int maxid = -1;
                if (reader.Read())
                {
                    maxid = int.Parse(reader["maxid"].ToString());
                }
                Close_Db();
                return maxid;
            }
            catch
            {
                return -1;
            }
        }
    }
    #endregion



}