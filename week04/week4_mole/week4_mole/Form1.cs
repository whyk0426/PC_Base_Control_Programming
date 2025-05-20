using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4_mole
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool[] isOpen = new bool[5] { false, false, false, false, false };

        public Form1()
        {
            InitializeComponent();
        }
        private void ClosedAll()
        {
            Card00.Image = Properties.Resources.closed;
            Card01.Image = Properties.Resources.closed;
            Card02.Image = Properties.Resources.closed;
            Card03.Image = Properties.Resources.closed;
            Card04.Image = Properties.Resources.closed;
            timer_close.Enabled = false;
            timer_open.Enabled = true;
            for (int i = 0; i < 5; i++)
                isOpen[i] = false;
        }

        private void timer_open_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(5); //5보다 작은 정수로 얻어져라. 다음꺼 나와라
            if (index == 0) 
                Card00.Image = Properties.Resources.open;
            if (index == 1) 
                Card01.Image = Properties.Resources.open;
            if (index == 2) 
                Card02.Image = Properties.Resources.open;
            if (index == 3) 
                Card03.Image = Properties.Resources.open;
            if (index == 4) 
                Card04.Image = Properties.Resources.open;
            timer_open.Enabled = false;
            timer_close.Enabled = true;
            isOpen[index] = true;
        }

        private void timer_close_Tick(object sender, EventArgs e)
        {
            ClosedAll();
        }

        private void Card0n_Click(object sender, EventArgs e) //속성에서 나머지 Card들도 모두 Card00_Click로
        {
            //PictureBox pic = sender as PictureBox;
            PictureBox pic = (PictureBox)sender;

            int indexHit = 0;
            if (pic == Card00)
                indexHit = 0;
            if (pic == Card01)
                indexHit = 1;
            if (pic == Card02)
                indexHit = 2;
            if (pic == Card03)
                indexHit = 3;
            if (pic == Card04)
                indexHit = 4;

            if (isOpen[indexHit])
            {
                int score = Convert.ToInt32(label_score.Text);
                label_score.Text = (++score).ToString();

                ClosedAll();
            }

        }
    }
}
