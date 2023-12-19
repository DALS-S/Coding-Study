using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloCSharp05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animal a = new animal();
            label1.Text = "나이 : " + a.Age;
            a.Eat();
            a.Sleep();
            // a.Born() 은 protected 이기에 바깥에선 호출 불가능
            // 바깥 -> animal을 상속 받지 않은 클래스
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cat c = new cat();  // born이 호출됨
            c.Age = 5;  // animal에 있는 age를 상속받음
            label2.Text = "고양이 나이 : " + c.Age;
            c.Eat();    // animal에 있는 메서드 상속받음
            c.Sleep();  // animal에 있는 메서드 상속받음
            c.Meow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dog d = new dog();  // 생성자 안에서 자동으로 born 호출
            d.Age = 17;
            d.Color = "흰색"; // 개 고유의 속성
            label3.Text = "개 나이 : " + d.Age + "\n";
            label3.Text += "개 색깔 : " + d.Color;
            d.Eat();
            d.Sleep();
            d.Bark();   // 개 고유의 메서드
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<animal> zoo = new List<animal>();
            zoo.Add(new animal());
            zoo.Add(new animal());
            zoo.Add(new dog());
            zoo.Add(new dog());
            zoo.Add(new cat());
            zoo.Add(new cat());
            foreach (var item in zoo)
            {
                item.Eat();
                item.Sleep();
                if (item is cat)              // 타입 체크 : is
                {
                    (item as cat).Meow();    // 형 변환 : as
                }
                if (item is dog)
                {
                    (item as dog).Bark();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 다형성
            // 왼쪽 = 오른쪽의 관계가
            // 오른쪽 is 왼쪽
            // 핸드폰 s  = new 스마트폰();
            // 스마트폰 is 핸드폰 (o)
            // 핸드폰 is 스마트폰 (x), 누군가는 아직 피쳐폰을 씀

            cat cat = new cat();
            dog dog = new dog();

            animal a = new dog();   // dog is animal
            animal b = new cat();   // cat is animal

            a.Age = 1;
            a.Eat();
            a.Sleep();
            ((dog)a).Bark(); // ok
            //((dog)b).Bark(); // b는 cat이므로 무작정 형변환시 오류가 난다.
            if (b is dog)
            {
                ((dog)b).Bark();
            }
            if (b is dog)
            {
                (b as dog).Bark();
            }
            var test = b as dog;
            Console.WriteLine(test == null);
            if (test != null)
            {
                test.Bark();
            }

            List<animal> animals = new List<animal>()
            {
                new dog(), new cat(), new dog()
            };
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(a);
            animals.Add(b);
            foreach(var item in animals) 
            {
                item.Eat();
                item.Sleep();
                if(item is dog)
                {
                    (item as dog).Bark();
                }
                if (item is cat)
                {
                    (item as cat).Meow();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // age는 인스턴스 별로 각자 다름
            // count 는 age, dog, cat이 공유 하고있음
            cat cat = new cat();
            dog dog = new dog();
            animal animal = new animal();
            cat.Age = 5;
            dog.Age = 7;
            animal.Age = 50;
            cat.count++;
            dog.count++;
            animal.count++;
            MessageBox.Show("count 값 : " + animal.count);
            MessageBox.Show("count 값 : " + cat.count);
            MessageBox.Show("count 값 : " + dog.count);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new animal().Wash();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cat c = new cat();
            (c as animal).Wash();
            new cat().Wash();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new dog().Wash();
        }
    }
}
