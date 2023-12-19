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
    public partial class Form1 : Form
    {
        // 체크펑크
        // 변수 타입
        // 메서드 저장하는 변수
        // 반환형은 bool 매개변수는 book을 갖는 메서드를 저장
        delegate bool CheckFunc(Book book);

        void refreshScreen()
        {
            label1.Text = "전체도서수:" + DataManager.books.Count;
            label2.Text = "전체회원수:" + DataManager.users.Count;
            //CheckFunc checkBorrowed = (b) =>
            //{
            //    return b.isBorrowed;
            //};
            label3.Text = "대출 중인 도서의 수 : "
                + DataManager.books.Where((b) =>
                {
                    return b.isBorrowed;
                }).Count();
            label4.Text = "연체 중인 도서의 수 : "
                + DataManager.books.Where(
                    delegate (Book b)
                    {
                        return b.isBorrowed
                        && b.BorrowedAt.AddDays(7) < DateTime.Now;
                    }).Count();
            bookBindingSource.DataSource = null;
            userBindingSource.DataSource = null;
            if (DataManager.books.Count > 0)
            {
                bookBindingSource.DataSource = DataManager.books;
            }
            if (DataManager.books.Count > 0)
            {
                userBindingSource.DataSource = DataManager.users;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns[0].HeaderText = "도서번호(ISBN)";
            dataGridView1.Columns[1].HeaderText = "도서명";
            dataGridView1.Columns[2].HeaderText = "출판사";
            dataGridView1.Columns[3].HeaderText = "페이지";
            dataGridView1.Columns[4].HeaderText = "회원ID";
            dataGridView1.Columns[5].HeaderText = "회원명";
            dataGridView1.Columns[6].HeaderText = "대여여부";
            dataGridView1.Columns[7].HeaderText = "대여일";
            label5.Text =
               DateTime.Now.ToString("yyyy년MM월dd일 HH시mm분ss초");
            label1.Text = "전체도서수:" + DataManager.books.Count;
            label2.Text = "전체회원수:" + DataManager.users.Count;
            refreshScreen();
            dataGridView1.CellClick += (s, e) =>
            {
                Book book =
                (s as DataGridView).CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.isbn;
                textBox2.Text = book.name;
            };
            DataGridViewCellEventHandler dCell2 = (s, e) =>
            {
                User u =
                (s as DataGridView).CurrentRow.DataBoundItem as User;
                textBox3.Text = u.Id;
            };
            dataGridView2.CellClick += dCell2;
            EventHandler borrow = borrowBook;
            button1.Click += borrow;
            button2.Click += returnBook;
        }

        void borrowBook(object s, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("isbn 없음");
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("사용자 ID 없음");
            }
            else
            {
                try
                {
                    Book b = DataManager.books.Single(x => x.isbn == textBox1.Text);
                    if (b.isBorrowed)
                    {
                        MessageBox.Show("대여 중인 책 입니다");
                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 입니다.");
                }
            }
        }

        void returnBook(object s, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            refreshScreen();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            refreshScreen();
        }
    }
}
