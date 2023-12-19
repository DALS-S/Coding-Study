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
    public partial class 광고 : Form
    {
        public 광고()
        {
            InitializeComponent();
        }
        Image picture;
        public Image Picture
        {
            get 
            { 
                return picture; 
            }
            set
            {
                picture = value;
                pictureBox1.Image = picture;
            }
        }
    }
}
