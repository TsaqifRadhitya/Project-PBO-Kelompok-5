﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.Model;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_MainMenu
    {
        C_MainFrame controller_main_frame;
        V_Main_Menu main_Menu;
        public C_MainMenu(C_MainFrame mainFrame)
        { 
            controller_main_frame = mainFrame;
            main_Menu = new V_Main_Menu(this);
            controller_main_frame.move_view(main_Menu);
        }

        public void logout()
        {
            M_Session.id_session = 0;
            M_Session.session_name = "";
            M_Session.session_status = false;
            controller_main_frame.controller_landing_page = new C_Landing_Page(controller_main_frame);
        }
    }
}
