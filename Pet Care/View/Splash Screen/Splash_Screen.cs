using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pet_Care.Contoller;

namespace Pet_Care.View.Splash_Screen
{
    public partial class Splash_Screen : Form
    {
        int time;
        public Splash_Screen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time < 30)
            {
                time++;
            }
            else
            {
                timer1.Stop();
                V_Main_Frame main_frame = new V_Main_Frame();
                this.Hide();
                main_frame.ShowDialog();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
