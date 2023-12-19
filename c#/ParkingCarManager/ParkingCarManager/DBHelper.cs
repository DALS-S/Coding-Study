using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarManager
{
    // mysql 이나 oracle 이랑 c# 연결하려면 nuget 패키지 필요함. 하지만 mssql은 별도의 설치 없이 연결 가능.
    public class DBHelper
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        private const string TABLENAME = " parkingCarManager ";

        private static void ConnectDB()     // DB 연결 메소드
        {
            string dataSource = "local";
            string db = "CarManager";
            string security = "SSPI";
            conn.ConnectionString =
                $"Data Source = ({dataSource}); initial Catalog = {db};" +
                $"integrated Security = {security};" +
                "Timeout = 3";
            conn.Open();
        }
        public static void selectQuery(string ps = "-1")
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (ps.Equals("-1"))
                {
                    cmd.CommandText = "select * from " + TABLENAME;
                }
                else
                {
                    cmd.CommandText = $"select * from {TABLENAME} where parkingSpot = '{ps}'";
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, TABLENAME);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                DataManager.printLog("select");
                DataManager.printLog(ex.Message);
                DataManager.printLog(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void updateQuery(string parkingSpot, string carnumber, string driverNumber, string phoneNumber, bool isRemove)    // 주차 or 출차
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sql = "";
                if (isRemove)
                {
                    sql = $"update {TABLENAME} set carnumber ='', " +
                        $"drivername ='', phonenumber = '', parkingtime = null " +
                        $"where parkingspot = @p1";
                    // sql injection : 해킹 방지
                    cmd.Parameters.AddWithValue("@p1", parkingSpot);
                }
                else
                {
                    sql = $"update {TABLENAME} set carnumber = @p1," +
                        $"drivername = @p2, phonenumber = @p3," +
                        $"parkingtime = @p4 where " +
                        $"parkingspot = @p5";
                    cmd.Parameters.AddWithValue("@p1", carnumber);
                    cmd.Parameters.AddWithValue("@p2", driverNumber);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpot);
                }
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DataManager.printLog("update," + e.Message + e.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        private static void executeQuery(string ps, string cmd)
        {
            string command = "";
            if(cmd.Equals("insert"))
            {
                command = $"insert into {TABLENAME} (parkingspot) values (@p1)";
            }
            else
            {
                command = $"delete from {TABLENAME} where parkingspot = @p1";
            }
            try
            {
                ConnectDB();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = conn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@p1", ps);
                sqlcmd.CommandText = command;
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DataManager.printLog(cmd + "," + e.Message + "\n" + e.StackTrace);
            }
            finally { conn.Close(); }
        }
        public static void deleteQuery(string ps)
        {
            executeQuery(ps, "delete");
        }
        public static void intsertQuery(string ps)
        {
            executeQuery(ps, "insert");
        }
    }
}
