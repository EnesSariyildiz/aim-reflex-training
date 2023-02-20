using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_reflex_training_project
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();


        public void RandomSayi()
        {
            int sayi = rnd.Next(0, 40);
            label2.Text = sayi.ToString();

            switch (label2.Text)
            {
                case "8":
                    pictureBox1.Show();
                    break;
                case "10":
                    pictureBox1.Hide();
                    break;
                case "13":
                    pictureBox2.Hide();
                    break;
                case "15":
                    pictureBox2.Show();
                    break;

                case "18":
                    pictureBox3.Hide();
                    break;
                case "21":
                    pictureBox3.Show();
                    break;

                default:
                    break;
            }

        }
        public void Reset()
        {
            sayac = 0;
            timer1.Stop();
            
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
        }

        public void Start()
        {
            sayac++;
            label1.Text = sayac.ToString();

            
        }
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        //int RastgeleSayi1 = rnd.Next(0, 15);
        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            RandomSayi();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
            //if (sayac == 100)
            //{
            //    timer1.Stop();
            //}
            RandomSayi();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void backToMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMainPage fr = new FrmMainPage();
            fr.Show();
            this.Hide();

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frm= new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SlateGray;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
