using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_Landing_Page
    {
        public C_MainFrame controller_main_frame;
        V_landing_Page v_Landing_Page;
        public V_Login v_Login;
        public V_Register V_Register;
        public C_Landing_Page(C_MainFrame Main_Frame)
        {
            controller_main_frame = Main_Frame;
            v_Landing_Page = new V_landing_Page(this);
            v_Login = new V_Login(this);
            v_Login.Location = new Point(0, 102);
            V_Register = new V_Register(this);
            controller_main_frame.move_view(v_Landing_Page);
            switch_view(v_Login);
        }

        public void switch_view(UserControl form)
        {
            v_Landing_Page.PanelInput.Controls.Clear();
            v_Landing_Page.PanelInput.Controls.Add(form);
        } 
    }
}
