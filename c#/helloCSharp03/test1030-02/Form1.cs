using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1030_02
{
    class Student
    {
        public string name;
        public int grade;   
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준", grade = 1 });
            students.Add(new Student() { name = "동준이", grade = 2 });
            students.Add(new Student() { name = "준동이", grade = 3 });
            students.Add(new Student() { name = "준준이", grade = 4 });
            students.Add(new Student() { name = "동동이", grade = 1 });
            students.Add(new Student() { name = "이이이", grade = 2 });

            for (int i = 0; i < students.Count; i++) 
            {
                Label label = new Label();
                label.Text = ( students[i].grade + "학년" + " " +students[i].name + "학생");
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(13, 13 + (23 + 3) * i);
                Controls.Add(label);
            }

            // 뭔가를 삭제 할 땐 역 for 문을 써야한다
            // 그래야 indexbounderror 나 indexoverflow 에러가 나지 않는다.
            for (int i =  students.Count - 1; i >= 0; i--) 
            {
                if (students[i].grade > 1)
                {
                    students.RemoveAt(i);
                }
            }

            for(int i = 0;i < students.Count;i++) 
            {
                Label label = new Label();
                label.Text = (students[i].grade + "학년" + " " + students[i].name + "학생");
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(130, 13 + (23 + 3) * i);
                Controls.Add(label);
            }           
        }
    }
}
