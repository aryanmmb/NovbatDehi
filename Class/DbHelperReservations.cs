using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NovbatDehi.Class
{
    public class DbHelperReservations
    {
        private readonly DbManager _mydb = new DbManager();

        public bool Add(Reservations reservation)
        {
            try
            {
                _mydb.Open_Db();
                var sql =
                    "INSERT INTO reservations(customer_id,_date,_time,paymentStatus,paymentKind,paymentCode,createTime,tozihat,FirstCome,_index,note,SmsResend)VALUES" +
                    "(@customer_id,@_date,@_time,@paymentStatus,@paymentKind,@paymentCode,@createTime,@tozihat,@FirstCome,@_index,@note,@SmsResend)";
                var cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstCome", reservation.FirstCome);
                cmd.Parameters.AddWithValue("@customer_id", reservation.customer_id);
                cmd.Parameters.AddWithValue("@_date", reservation.date);
                cmd.Parameters.AddWithValue("@paymentCode", reservation.paymentCode);
                cmd.Parameters.AddWithValue("@paymentKind", reservation.paymentKind);
                cmd.Parameters.AddWithValue("@paymentStatus", reservation.paymentStatus);
                cmd.Parameters.AddWithValue("@tozihat", reservation.tozihat);
                cmd.Parameters.AddWithValue("@_time", reservation.time);
                cmd.Parameters.AddWithValue("@createTime", reservation.createTime);
                cmd.Parameters.AddWithValue("@_index", reservation._index);
                cmd.Parameters.AddWithValue("@note", reservation.note);
                cmd.Parameters.AddWithValue("@SmsResend", reservation.SmsResend);

                cmd.ExecuteNonQuery();
                _mydb.Close_Db();
                return true;
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                return false;
            }
        }

        public Reservations Get_Reservation_By_id(int reservationId)
        {
            try
            {
                Reservations tmpResult = null;
                _mydb.Open_Db();
                var cmd = new SqlCommand("select * from reservations where id= " + reservationId,
                    _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                    tmpResult = new Reservations
                    {
                        FirstCome = reader["FirstCome"].ToString(),
                        createTime = reader["createTime"].ToString(),
                        customer_id = reader["customer_id"].ToString().ToInt(),
                        date = reader["date"].ToString(),
                        id = reader["id"].ToString().ToInt(),
                        tozihat = reader["tozihat"].ToString(),
                        paymentCode = reader["paymentCode"].ToString(),
                        paymentKind = reader["paymentKind"].ToString(),
                        paymentStatus = reader["paymentStatus"].ToString(),
                        time = reader["time"].ToString(),
                        _index = reader["_index"].ToString().ToInt(),
                        note = reader["note"].ToString(),
                        SmsResend = reader["SmsResend"].ToString().ToBool(),
                    };
                _mydb.Close_Db();
                return tmpResult;
            }
            catch
            {
                return null;
            }
        }

        public List<Reservations> Get_All_Reservations(string date = "")
        {
            try
            {
                _mydb.Open_Db();
                var locaList = new List<Reservations>();
                var sql =
                    "select * from reservations left join customers on reservations.customer_id=customers.id" +
                    (date == "" ? "" : " where _date=N'" + date + "'")
                    + " order by _time";

                var cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                var reader = cmd.ExecuteReader();
                var indexer = 1;
                while (reader.Read())
                    locaList.Add(new Reservations
                    {
                        FirstCome = reader["FirstCome"].ToString() == "" ? "..." : reader["FirstCome"].ToString(),
                        createTime = reader["createTime"].ToString() == "" ? "..." : reader["FirstCome"].ToString(),
                        customer_id = reader["customer_id"].ToString().ToInt(),
                        date = reader["_date"].ToString(),
                        id = reader["id"].ToString().ToInt(),
                        tozihat = reader["tozihat"].ToString(),
                        paymentCode = reader["paymentCode"].ToString() == "" ? "..." : reader["paymentCode"].ToString(),
                        paymentKind = reader["paymentKind"].ToString() == "" ? "..." : reader["paymentKind"].ToString(),
                        paymentStatus = reader["paymentStatus"].ToString() == "" ? "..." : reader["paymentStatus"].ToString(),
                        time = reader["_time"].ToString() == "" ? "..." : reader["_time"].ToString(),
                        fullname = reader["fullname"].ToString() == "" ? "..." : reader["fullname"].ToString(),
                        mobile = reader["mobile"].ToString() == "" ? "..." : reader["mobile"].ToString(),
                        code = reader["code"].ToString() == "" ? "..." : reader["code"].ToString(),
                        _index = reader["_index"].ToString().ToInt(),
                        Radif = indexer++,
                        note = reader["note"].ToString(),
                        SmsResend = reader["SmsResend"].ToString().ToBool(),
                    });

                _mydb.Close_Db();
                return locaList;
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                return null;
            }
        }

        public bool Delete(int reservationsId)
        {
            try
            {
                _mydb.Open_Db();
                var cmd = new SqlCommand("delete from Reservations where id=" + reservationsId,
                    _mydb.GetConnection_Db());
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

        public bool Update(int reservationsId, Reservations reservation)
        {
            try
            {
                _mydb.Open_Db();
                var sql =
                    "UPDATE  reservations SET customer_id=@customer_id,_date=@_date,_time=@_time,paymentStatus=@paymentStatus" +
                    ",paymentKind=@paymentKind,paymentCode=@paymentCode,createTime=@createTime,tozihat=@tozihat,FirstCome=@FirstCome,_index=@_index,note=@note,SmsResend=@SmsResend  where id=@id";
                var cmd = new SqlCommand(sql, _mydb.GetConnection_Db());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstCome", reservation.FirstCome);
                cmd.Parameters.AddWithValue("@createTime", reservation.createTime);
                cmd.Parameters.AddWithValue("@customer_id", reservation.customer_id);
                cmd.Parameters.AddWithValue("@_date", reservation.date);
                cmd.Parameters.AddWithValue("@paymentCode", reservation.paymentCode);
                cmd.Parameters.AddWithValue("@paymentKind", reservation.paymentKind);
                cmd.Parameters.AddWithValue("@paymentStatus", reservation.paymentStatus);
                cmd.Parameters.AddWithValue("@tozihat", reservation.tozihat);
                cmd.Parameters.AddWithValue("@_time", reservation.time);
                cmd.Parameters.AddWithValue("@id", reservationsId);
                cmd.Parameters.AddWithValue("@_index", reservation._index);
                cmd.Parameters.AddWithValue("@note", reservation.note);
                cmd.Parameters.AddWithValue("@SmsResend", reservation.SmsResend);
                cmd.ExecuteNonQuery();
                _mydb.Close_Db();
                return true;
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                return false;
            }
        }
    }
}