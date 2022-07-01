using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NovbatDehi.Class
{
    public class DbHelperCustomers
    {
        private readonly DbManager _mydb = new DbManager();

        public bool Add(Customer customer)
        {
            try
            {
                _mydb.Open_Db();
                var sql =
                    "INSERT INTO customers(code,fullname,mobile,mobile2,mobile3,birthDate,irCode, bimeCode, tozihat,lastUpdate,createTime)VALUES" +
                    "(@code,@fullname,@mobile,@mobile2,@mobile3,@birthDate,@irCode,@bimeCode,@tozihat,@lastUpdate,@createTime)";
                var cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@code", customer.code);
                cmd.Parameters.AddWithValue("@fullname", customer.fullname);
                cmd.Parameters.AddWithValue("@mobile", customer.mobile);
                cmd.Parameters.AddWithValue("@mobile2", customer.mobile2);
                cmd.Parameters.AddWithValue("@mobile3", customer.mobile3);
                cmd.Parameters.AddWithValue("@birthDate", customer.birthDate);
                cmd.Parameters.AddWithValue("@irCode", customer.irCode);
                cmd.Parameters.AddWithValue("@bimeCode", customer.bimeCode);
                cmd.Parameters.AddWithValue("@tozihat", customer.tozihat);
                cmd.Parameters.AddWithValue("@lastUpdate", customer.lastUpdate);
                cmd.Parameters.AddWithValue("@createTime", customer.createTime);
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

        public Customer Get_Customer_By_id(int customerId)
        {
            try
            {
                Customer tmpResult = null;
                _mydb.Open_Db();
                var cmd = new SqlCommand("select * from customers where id= " + customerId, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                    tmpResult = new Customer
                    {
                        code = reader["code"].ToString(),
                        fullname = reader["fullname"].ToString(),
                        irCode = reader["irCode"].ToString(),
                        bimeCode = reader["bimeCode"].ToString(),
                        birthDate = reader["birthDate"].ToString(),
                        createTime = reader["createTime"].ToString(),
                        tozihat = reader["tozihat"].ToString(),
                        id = reader["id"].ToString().ToInt(),
                        lastUpdate = reader["lastUpdate"].ToString(),
                        mobile = reader["mobile"].ToString(),
                        mobile2 = reader["mobile2"].ToString(),
                        mobile3 = reader["mobile3"].ToString()
                    };
                _mydb.Close_Db();
                return tmpResult;
            }
            catch
            {
                return null;
            }
        }

        public int GetLastFreeCode()
        {
            try
            {
                var maxid = -1;

                _mydb.Open_Db();
                var cmd = new SqlCommand(" SELECT ISNULL(MAX(code), 0) + 1 as maxcode FROM[customers]",
                    _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                if (reader.Read()) maxid = int.Parse(reader["maxcode"].ToString());
                _mydb.Close_Db();
                return maxid;
            }
#pragma warning disable CS0168 // The variable 'e' is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
            {
                return -1;
            }
        }

        public List<Customer> Get_All_Customer()
        {
            try
            {
                _mydb.Open_Db();
                var locaList = new List<Customer>();
                var cmd = new SqlCommand("select * from Customers order by code desc", _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    locaList.Add(new Customer
                    {
                        code = reader["code"].ToString(),
                        fullname = reader["fullname"].ToString(),
                        irCode = reader["irCode"].ToString(),
                        bimeCode = reader["bimeCode"].ToString(),
                        birthDate = reader["birthDate"].ToString(),
                        createTime = reader["createTime"].ToString(),
                        tozihat = reader["tozihat"].ToString(),
                        id = reader["id"].ToString().ToInt(),
                        lastUpdate = reader["lastUpdate"].ToString(),
                        mobile = reader["mobile"].ToString(),
                        mobile2 = reader["mobile2"].ToString(),
                        mobile3 = reader["mobile3"].ToString()
                    });
                _mydb.Close_Db();
                return locaList;
            }
            catch
            {
                return null;
            }
        }

        public bool CheckDuplicate(string code)
        {
            try
            {
                _mydb.Open_Db();
                var cmd = new SqlCommand("select * from Customers where code=" + code, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                var result = reader.Read();
                _mydb.Close_Db();
                return result;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public bool Delete(int customersId)
        {
            try
            {
                _mydb.Open_Db();
                var cmd = new SqlCommand("delete from Customers where id=" + customersId, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                _mydb.Close_Db();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(int customerId, Customer customer)
        {
            try
            {
                _mydb.Open_Db();
                var sql =
                    "UPDATE  customers SET code =@code,fullname=@fullname,mobile=@mobile,mobile2=@mobile2" +
                    ",mobile3=@mobile3,birthDate=@birthDate,irCode=@irCode,bimeCode=@bimeCode" +
                    ",tozihat=@tozihat,lastUpdate=@lastUpdate,createTime=@createTime where id=@id";
                var cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@code", customer.code);
                cmd.Parameters.AddWithValue("@fullname", customer.fullname);
                cmd.Parameters.AddWithValue("@mobile", customer.mobile);
                cmd.Parameters.AddWithValue("@mobile2", customer.mobile2);
                cmd.Parameters.AddWithValue("@mobile3", customer.mobile3);
                cmd.Parameters.AddWithValue("@birthDate", customer.birthDate);
                cmd.Parameters.AddWithValue("@irCode", customer.irCode);
                cmd.Parameters.AddWithValue("@bimeCode", customer.bimeCode);
                cmd.Parameters.AddWithValue("@tozihat", customer.tozihat);
                cmd.Parameters.AddWithValue("@lastUpdate", customer.lastUpdate);
                cmd.Parameters.AddWithValue("@createTime", customer.createTime);
                cmd.Parameters.AddWithValue("@id", customerId);
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