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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Point point = new Point();
            
            point.X = rand.Next(0, 400);
            point.Y = rand.Next(0, 400);
            
            
            pictureBox1.Location = point;
        }
    }
}
