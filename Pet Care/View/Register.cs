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
    public partial class Register : UserControl
    {
        Form1 form1;
        public Register(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            form1.pindah_user_control(new Login(form1));
        }
    }
}
