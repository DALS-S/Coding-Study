using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloCSharp03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            product.companyName = "경북산업마트";

            // 첫번째 방법 = 직접 대입
            product p1 = new product();
            p1.name = "마이크";
            p1.price = 100000;
            product p2 = new product();
            p2.name = "새콤달콤";
            p2.price = 500;
            product p3 = new product();
            p3.name = "새콤달콤";
            p3.price = 500;

            // 두번째 방법 = 선언과 동시에 값을 대입 (생성자랑 관계 없음)
            product p4 = new product() { name = "바디워시", price = 5000 };

            // 세번째 방법 = 생성자를 활용하는 방법(자바와 동일)
            students s1 = new students(1, "이경민");


            // f5 로 출력 확인 가능
            Console.WriteLine(p2 == p3);
            //MessageBox.Show("Test" + (p2 == p3));

            animal a = new animal();
            a.setmasterName("이경민");
            Console.WriteLine(a.gertMasterName());
            a.Species = "개";    // 개 = values
            Console.WriteLine(a.Species);   // get으로 species 리턴
            a.Id = 1;   // 1 = values
            Console.WriteLine(a.Id);    // get으로 id 리턴
            a.name = "구구";
            a.age = 10;

            GameCharacter g1 = new GameCharacter();
            g1.Id = "캐릭터1";
            GameCharacter g2 = new GameCharacter("캐릭터2");
            MessageBox.Show(GameCharacter.theNumberOfUser+"명");

            List<GameCharacter> list = new List<GameCharacter>();
            list.Add(g1);
            list.Add(g2);

            int i = 1;
            foreach(var item in list)
            {
                Label label = new Label();
                label.Text = item.Id;
                label.Location = new Point(10, 10 + (100 * i));
                i++;
                Controls.Add(label);
            }

        }
    }
}
