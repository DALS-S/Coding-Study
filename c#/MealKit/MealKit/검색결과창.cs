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
    public partial class 검색결과창 : Form
    {
        public 검색결과창()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //DataManager.KitLoad();
            //UpdateGridView();
            try
            {
                DBHelper.selectQuery();

                // 기존에 panel1에 추가된 컨트롤들을 모두 제거
                panel1.Controls.Clear();

                int itemsPerRow = 5; // 가로로 배치할 UC_Item 개수
                int itemWidth = 150; // UC_Item의 가로 길이
                int itemHeight = 200; // UC_Item의 세로 길이
                int horizontalSpacing = 50; // 가로 간격
                int verticalSpacing = 10; // 세로 간격

                int rowIndex = 0;
                int colIndex = 0;

                foreach (DataRow row in DBHelper.dt.Rows)
                {
                    Product product = new Product
                    {
                        item_name = row["item_name"].ToString(),
                        item_kind = row["item_kind"].ToString(),
                        item_price = Convert.ToInt32(row["item_price"]),                      
                    };

                    UC_Item ucItem = new UC_Item();
                    ucItem.itemName = product.item_name;
                    ucItem.itemPrice = product.item_price.ToString();
                    string imageName = product.item_name;
                    var image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                    if (image != null)
                    {
                        ucItem.itemImage = image;

                        // UC_Item 위치 설정
                        int x = colIndex * (itemWidth + horizontalSpacing);
                        int y = rowIndex * (itemHeight + verticalSpacing);
                        ucItem.Location = new Point(x, y);

                        panel1.Controls.Add(ucItem);

                        // 다음 열로 이동
                        colIndex++;

                        // 다음 행으로 이동
                        if (colIndex >= itemsPerRow)
                        {
                            colIndex = 0;
                            rowIndex++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Image '{imageName}' not found in Resources.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in button1_Click: {ex.Message}");
            }
        }
        //private void UpdateGridView()
        //{
        //    // dataGridView1은 그리드뷰의 이름입니다. 
        //    dataGridView1.DataSource = DataManager.products; // GetKitData는 실제로 데이터를 반환하는 메서드입니다.
        //}
        //private void UpdateGridView2()  
        //{
        //    // dataGridView1은 그리드뷰의 이름입니다. 
        //    dataGridView1.DataSource = DBHelper.dt; // GetKitData는 실제로 데이터를 반환하는 메서드입니다.
        //}
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//엔터 키 누르고 다시 올라올 때
                button1.PerformClick(); //클릭 강제 호출
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            메인화면 frm1 = new 메인화면();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            장바구니 frm2 = new 장바구니();
            frm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            회원정보 frm3 = new 회원정보();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = textBox1.Text;
                DBHelper.searchQuery(searchKeyword);

                // 기존에 panel1에 추가된 컨트롤들을 모두 제거
                panel1.Controls.Clear();

                // 검색 결과를 동적으로 생성한 UC_Item 컨트롤에 표시
                foreach (DataRow row in DBHelper.dt.Rows)
                {
                    Product product = new Product
                    {
                        item_name = row["item_name"].ToString(),
                        item_kind = row["item_kind"].ToString(),
                        item_price = Convert.ToInt32(row["item_price"]),
                        // 여기에 필요한 다른 속성들을 추가하세요
                    };

                    UC_Item ucItem = new UC_Item();
                    ucItem.itemName = product.item_name;
                    ucItem.itemPrice = product.item_price.ToString();

                    // 이미지를 설정
                    // Resources 폴더에 이미지를 넣고 이미지 파일 이름을 가져와서 설정
                    string imageName = product.item_name; // item_name을 사용
                    var image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                    if (image != null)
                    {
                        ucItem.itemImage = image;
                        panel1.Controls.Add(ucItem);
                    }
                    else
                    {
                        Console.WriteLine($"Image '{imageName}' not found in Resources.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in button1_Click: {ex.Message}");
            }
        }
    }
}
