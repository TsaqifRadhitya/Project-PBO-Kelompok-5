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
    public partial class Login : UserControl
    {
        Form1 Form1;
        public Login(Form1 form)
        {
            InitializeComponent();
            this.Form1 = form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.pindah_user_control(new Register(Form1));
        }
    }
}