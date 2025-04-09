using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Human human = new Human();
            human.age = 20;
            //human.added1 = 

            Man man = new Man();
            man.age = 21;       // 상속 받은 속성
            man.added1 = 99;    // 추가된 속성
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.favorite();

            Man man = new Man();
            man.favorite();

            Woman woman = new Woman();
            woman.favorite();

            // 1
            human = man;
            human.favorite();

            // 2
            human = woman;
            human.favorite();

        }

        Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            // 만들기
            Human[] human = new Human[100];
            for(int i=0; i<100; i++)
            {
                int idx = rnd.Next(3);
                if (idx == 0) human[i] = new Human();

                if (idx == 1) human[i] = new Man();

                if (idx == 2) human[i] = new Woman();
            }

            //출력하기
            for (int i =0; i<100; i++)
            {
                human[i].favorite();
            }
        }
    }
}
