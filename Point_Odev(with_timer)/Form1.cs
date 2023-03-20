using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Odev_with_timer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        Point konum = new Point();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            konum.X = 200;
            konum.Y = 200;
            pictureBox1.Location = konum;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 3)
            {
                konum.X = 200;
                konum.Y = 200;
                pictureBox1.Location = konum;
            }
            if (sayac == 6)
            {
                konum.X = 200;
                konum.Y = 150;
                pictureBox1.Location = konum;
            }
            if (sayac == 9)
            {
                konum.X = 200;
                konum.Y = 100;
                pictureBox1.Location = konum;
            }
            if (sayac == 12)
            {
                konum.X = 200;
                konum.Y = 50;
                pictureBox1.Location = konum;
            }
            if (sayac == 15)
            {
                timer1.Stop();
                button1.Enabled = false;
            }
        }


    }
}
