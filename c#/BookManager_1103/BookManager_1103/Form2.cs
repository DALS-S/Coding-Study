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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (DataManager.books.Count > 0)
            {
                bookBindingSource.DataSource = DataManager.books;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            foreach (var item in DataManager.books)
            {
                if (item.isbn == textBox1.Text)
                {
                    existBook = true;
                    break;
                }
                
            }
            if (existBook == true)
            {
                MessageBox.Show("이미 해당 책이 존재합니다.");
            }
            else
            {
                Book book = new Book();
                book.isbn = textBox1.Text;
                book.name = textBox2.Text;
                book.publisher = textBox3.Text;
                int.TryParse(textBox4.Text, out int page);
                book.page = page;
                if (page <= 0)
                {
                    throw new Exception("페이지가 이상하다");
                    return;
                }
                DataManager.books.Add(book);
                bookBindingSource.DataSource = null;
                bookBindingSource.DataSource = DataManager.books;
                DataManager.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book b = null;
            for (int i = 0; i < DataManager.books.Count; i++)
            {
                if (DataManager.books[i].isbn == textBox1.Text)
                {   // b의 name 등이 바뀌면 datamanager[i]에 있는 내용도 같이 바뀜 (참조변수)
                    b = DataManager.books[i];
                    b.name = textBox2.Text;
                    b.publisher = textBox3.Text;
                    int.TryParse(textBox4.Text, out int page);
                    b.page = page;
                    if (page <= 0)
                    {
                        MessageBox.Show("페이지 값이 이상하다");
                        return;
                    }
                    bookBindingSource.DataSource = null;
                    bookBindingSource.DataSource = (DataManager.books);
                    DataManager.Save();
                }
            }
            if (b == null)
            {
                MessageBox.Show("존재하지 않는 책입니다");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            for(int i = 0;i < DataManager.books.Count; i++)
            {
                if (DataManager.books[i].isbn == textBox1.Text)
                {
                    DataManager.books.RemoveAt(i);
                    existBook = true;
                }
            }
            if(existBook)
            {
                bookBindingSource.DataSource = null;
                if(DataManager.books.Count > 0)
                {
                    bookBindingSource.DataSource = DataManager.books;
                }
                DataManager.Save();
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않아 삭제를 할 수 없습니다.");  
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book b = dataGridView1.CurrentRow.DataBoundItem as Book;
            textBox1.Text = b.isbn;
            textBox2.Text = b.name;
            textBox3.Text = b.publisher;
            textBox4.Text = b.page.ToString();
        }
    }
}
