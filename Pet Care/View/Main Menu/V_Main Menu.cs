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
    public partial class V_Main_Menu : UserControl
    {
        C_MainMenu controller;
        public V_Main_Menu(C_MainMenu mainMenu)
        {
            InitializeComponent();
            controller = mainMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Log_Out_Hover;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Log_Out;
        }
    }
}
