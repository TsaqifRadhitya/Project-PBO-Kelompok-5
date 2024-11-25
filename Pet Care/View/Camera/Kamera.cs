using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Care.View
{
    public partial class Kamera : Form
    {
        public Kamera()
        {
            InitializeComponent();
        }

        private void Shutter_Click(object sender, EventArgs e)
        {

        }

        private void Shutter_MouseHover(object sender, EventArgs e)
        {
            Shutter.Cursor = Cursors.Hand;
        }

        private void Shutter_MouseEnter(object sender, EventArgs e)
        {
            Shutter.BackgroundImage = Properties.Resources.Shutter_Hover;
        }

        private void Shutter_MouseLeave(object sender, EventArgs e)
        {
            Shutter.BackgroundImage = Properties.Resources.Shutter;
        }
    }
}
