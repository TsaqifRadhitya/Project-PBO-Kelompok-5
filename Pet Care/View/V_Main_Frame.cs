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

namespace Pet_Care.View
{
    public partial class V_Main_Frame : Form
    {
        C_MainFrame mainFrame;
        public V_Main_Frame()
        {
            InitializeComponent();
            mainFrame = new C_MainFrame(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
