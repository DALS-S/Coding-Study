using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager_1103
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            if (DataManager.users.Count > 0)
            {
                dataGridView1.DataSource = DataManager.users;
            }
            dataGridView1.CellClick += DataGridView1CellClick;
            button1.Click += AddUser;
            button2.Click += delegate (object s, EventArgs e)
            {
                try
                {
                    // single : 괄호 안에 있는 메서드의 조건을 만족하는 객체의 위치를 가져옴
                    // 만약에 해다조건을 충족하는 객체가 없으면 예외를 발생시킴
                    // 여기서 리턴된 유는 데이터매니저점유저스 안에있는 요소의 위치를 참조하므로 n.name 을 바꾸면 유저스에 있는 그 객체의 name이 바뀜
                    User u = DataManager.users.Single(x => x.Id == textBox1.Text);
                    u.Name = textBox2.Text;
                    try
                    {
                        Book b = DataManager.books.Single(x => x.userId == textBox1.Text);
                        b.userName = textBox2.Text;
                    }
                    catch (Exception)
                    {


                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 아이디 입니다.");
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.users;
                DataManager.Save();
            };

            button3.Click += (s, e) =>
            {
                try
                {
                    User u = DataManager.users.Single
                    (x => x.Id == textBox1.Text);
                    DataManager.users.Remove(u);
                    dataGridView1.DataSource = null;
                    if (DataManager.users.Count > 0)
                    {
                        dataGridView1.DataSource = DataManager.users;
                    }
                    DataManager.Save();
                }
                catch (Exception)
                {


                }
            };
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User u = (sender as DataGridView).CurrentRow.DataBoundItem as User;
            textBox1.Text = u.Id;
            textBox2.Text = u.Name;
        }
        private void AddUser(object s, EventArgs e)
        {
            // exist : 메서드를 매개변수로 하는 메서드
            // 저 괄호 안에 들어가는 메서드는 리턴 타입이 트루나 펄스여야함
            // 여기서 엑스는 유저스에 있는 모든 사용자들을 의미
            // 모든 사용자 중에서 텍박1텍스트랑 일치하는 아이디를 가진 사용자가 한명이라도 있으면 트루를 리턴하고 그러면 엑시스트 자체도 트루를 리턴함
            // 매개변수는 유저 타입 변수
            if (DataManager.users.Exists(x => x.Id == textBox1.Text))
            {
                MessageBox.Show("존재하는 아이디 입니다");
            }
            else
            {
                User u = new User() { Id = textBox1.Text, Name = textBox2.Text };
                DataManager.users.Add(u);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.users;
                DataManager.Save();
            }
        }
    }
}
