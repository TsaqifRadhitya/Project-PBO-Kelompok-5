using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Controller
{
    public abstract class C_Message_Box
    {
        public bool confirmed;
        public void show_message_box(string message)
        {
            V_Custom_Message_Box message_Box = new V_Custom_Message_Box(message);
            message_Box.ShowDialog();
        }
        public bool show_confirm_message_box(string message)
        {
            Custom_Message_Box_2_Button messagebox = new Custom_Message_Box_2_Button(this, message);
            messagebox.ShowDialog();
            if (confirmed)
            {
                confirmed = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
