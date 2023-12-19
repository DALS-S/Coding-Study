using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear();
                foreach (DataRow item in DBHelper.dt.Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.parkingSpot = item["parkingSpot"].ToString();
                    car.carNumber = item["carNumber"].ToString();
                    car.driverName = item["driverName"].ToString();
                    car.phoneNumber = item["phoneNumber"].ToString();
                    car.parkingTime = item["parkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["parkingTime"].ToString());
                    Cars.Add(car);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
        public static void Save(string ps, string carNumber, string driverName, string phoneNumber, bool isRemove = false)
        {
            try
            {
                DBHelper.updateQuery(ps, carNumber, driverName, phoneNumber, isRemove);
            }
            catch (Exception)
            {

            }
        }

        // 주차공간 추가 삭제
        public static bool Save(string cmd, string ps, out string contents)
        {
            DBHelper.selectQuery(ps);

            contents = "";
            if(cmd.Equals("insert"))
            {
                return DBInsert(ps, ref contents);
            }
            else
            {
                return DBDelete(ps, ref contents);
            }
        }
        private static bool DBInsert(string ps, ref string contents)
        {
            if(DBHelper.dt.Rows.Count==0)
            {
                DBHelper.intsertQuery(ps);
                contents = $" 주차공간 {ps} 추가됨";
                return true;
            }
            else
            {
                contents = " 해당 공간 이미 있음";
                return false;
            }
        }
        private static bool DBDelete(string ps, ref string contents)
        {
            if (DBHelper.dt.Rows.Count == 0)
            {
                contents = " 해당 공간 없음(삭제)";
                return false;
            }
            else
            {
                DBHelper.deleteQuery(ps);
                contents = $" 주차공간 {ps} 삭제됨";
                return true;
            }
        }
        public static void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("LogFolder");
            if (di.Exists == false)
            {
                di.Create();
            }
            // using :: 메모리를 할당하고 나서 다 쓰고 나면 자동으로 소멸 시켜줌
            using (StreamWriter w = new StreamWriter(@"LogFolder\ParkingHistory.txt", true))
            {
                w.WriteLine(contents);
            }
        }
    }
}
