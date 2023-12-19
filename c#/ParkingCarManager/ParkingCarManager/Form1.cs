using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "주차";
            button2.Text = "출차";
            button3.Text = "공간 추가";
            button4.Text = "공간 삭제";
            button5.Text = "차량 조회";
            button6.Text = "전체 조회";
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                textBox1.Text = DataManager.Cars[0].parkingSpot;
                textBox2.Text = DataManager.Cars[0].carNumber;
                textBox3.Text = DataManager.Cars[0].driverName;
                textBox4.Text = DataManager.Cars[0].phoneNumber;
                textBox5.Text = textBox1.Text;

            }
            catch (Exception)
            {


            }
            if (DataManager.Cars.Count > 0)
            {
                dataGridView1.DataSource = DataManager.Cars;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //writeLog("버튼 1 클릭");
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show(" 주차 공번 번호를 입력하시오");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("차량 번호를 입력하시오");
            }
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single(x => x.parkingSpot == textBox1.Text);
                    if (car.carNumber.Trim() != "")
                    {
                        MessageBox.Show(" 이미 주차된 차가 있습니다");
                    }
                    else
                    {
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;

                        DataManager.Save(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        string contents = $" 주차공간 {textBox1.Text} 에 {textBox2.Text} 차를 주차함";
                        MessageBox.Show(contents);
                        writeLog(contents);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" 주차공간 {textBox1.Text} 없음");
                    writeLog($" 주차공간 {textBox1.Text} 없음");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //writeLog("버튼 1 클릭");
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show(" 주차 공번 번호를 입력하시오");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("차량 번호를 입력하시오");
            }
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single(x => x.parkingSpot == textBox1.Text);
                    if (car.carNumber.Trim() == "")
                    {
                        MessageBox.Show(" 주차된 차가 없습니다");
                    }
                    else
                    {
                        string oldCar = car.carNumber;
                        car.carNumber = "";
                        car.driverName = "";
                        car.phoneNumber = "";
                        car.parkingTime = new DateTime();

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;

                        DataManager.Save(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,true);
                        string contents = $" 주차공간 {textBox1.Text} 에 {oldCar} 차를 출차함";
                        MessageBox.Show(contents);
                        writeLog(contents);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" 주차공간 {textBox1.Text} 없음");
                    writeLog($" 주차공간 {textBox1.Text} 없음");
                }
            }
        }

        private void spot_add_delete(string ps, string cmd)
        {
            ps = ps.Trim();
            string contents = "";
            bool check = DataManager.Save(cmd, ps, out contents);
            if (check)
            {
                button6.PerformClick();
            }
            MessageBox.Show(contents);
            writeLog(contents);
        }
        private void button3_Click(object sender, EventArgs e)      // 주차 공간 추가
        {
            //writeLog("버튼 3 클릭");
            spot_add_delete(textBox5.Text, "insert");
        }

        private void button4_Click(object sender, EventArgs e)      // 주차 공간 삭제
        {
            //writeLog("버튼 4 클릭");
            spot_add_delete(textBox5.Text, "delete");
        }

        private string lookUpParkingSpot(string parkingSpot)
        {
            string parkedCarNum = "";
            foreach (var item in DataManager.Cars)
            {
                if (item.parkingSpot == parkingSpot)
                {
                    parkedCarNum = item.carNumber;
                    break;
                }
            }
            return parkedCarNum;
        }
        private void button5_Click(object sender, EventArgs e)      // 특정 공간 정보 출력
        {
            //writeLog("버튼 5 클릭");
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show(" 조회 할 공간 번호를 입력하세요.");
                return;
            }
            string ps = textBox5.Text;
            string parkedCar = lookUpParkingSpot(ps);
            string contents = "";
            if (parkedCar.Trim() != "")
            {
                contents = $" 주차공간 {ps} 에 주차된 차는 {parkedCar} 입니다.";
            }
            else
            {
                contents = $" 주차공간 {ps} 에 주차된 차가 없습니다.";
            }
            MessageBox.Show(contents);
            writeLog(contents);
        }

        private void button6_Click(object sender, EventArgs e)      // 전체 조회(갱신)
        {
            //writeLog("버튼 6 클릭");
            DataManager.Load();
            dataGridView1.DataSource = null;
            if (DataManager.Cars.Count > 0)
            {
                dataGridView1.DataSource = DataManager.Cars;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParkingCar car = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
            textBox1.Text = car.parkingSpot;
            textBox2.Text = car.carNumber;
            textBox3.Text = car.driverName;
            textBox4.Text = car.phoneNumber;
            textBox5.Text = textBox1.Text;
        }
        private void writeLog(string contents)
        {
            string log = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]";
            log += contents;
            DataManager.printLog(log);
            listBox1.Items.Insert(0, log);
        }
    }
}
