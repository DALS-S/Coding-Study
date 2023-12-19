using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1101
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            IsMdiContainer = true;  // 자기 자신을 mdi 컨테이너로 만듦 (Form2 안에 모든 창들이 다 뜨게 할 것)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyForm m = new MyForm();
            m.MdiParent = this;
            m.Show();
        }
    }
}
