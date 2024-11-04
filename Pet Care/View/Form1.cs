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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new Login(this));
        }
        public void pindah_user_control(UserControl userControl) {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
        }


    }
}
