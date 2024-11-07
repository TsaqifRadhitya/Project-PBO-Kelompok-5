using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_MainFrame
    {
        V_Main_Frame main_Frame;
        public C_Landing_Page controller_landing_page;
        public C_MainMenu controller_main_menu;
        public C_MainFrame(V_Main_Frame main_frame)
        {
            this.main_Frame = main_frame;
            controller_landing_page = new C_Landing_Page(this);
        }

        public void move_view(UserControl view)
        {
            main_Frame.panel1.Controls.Clear();
            main_Frame.panel1.Controls.Add(view);
        }

        public void show_message_box(string message)
        {
            V_Custom_Message_Box message_Box = new V_Custom_Message_Box(this, message);
            message_Box.ShowDialog();
        }
    }
}
