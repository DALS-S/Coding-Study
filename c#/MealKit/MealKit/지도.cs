using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealKit
{
    public partial class 지도 : Form
    {
        public 지도()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Locale> locales = MapAPI.Search(textBox1.Text);
            listBox1.Items.Clear();
            foreach (Locale item in locales)
                listBox1.Items.Add(item);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//엔터 키 누르고 다시 올라올 때
                button1.PerformClick(); //클릭 강제 호출
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            Locale ml = listBox1.SelectedItem as Locale;//클릭한 걸 Locale로 변경
            object[] pos = new object[] { ml.Lat, ml.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", pos);
        }
    }
}
