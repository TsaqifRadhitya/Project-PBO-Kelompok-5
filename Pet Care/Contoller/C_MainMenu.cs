using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.Model;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_MainMenu : C_Message_Box
    {
        public C_MainFrame controller_main_frame;
        V_Main_Menu main_Menu;
        public string menu_focus = typeof(V_Dashboard).Name;
        public C_MainMenu(C_MainFrame mainFrame)
        { 
            controller_main_frame = mainFrame;
            main_Menu = new V_Main_Menu(this);
            controller_main_frame.move_view(main_Menu);
            C_Dashboard c_Dashboard = new C_Dashboard(this);
        }

        public void move_view(UserControl view)
        {
            main_Menu.panel1.Controls.Clear();
            main_Menu.panel1.Controls.Add(view);
        }

        public void logout()
        {
            if(show_confirm_message_box("Apakah Anda Yakin  ?"))
            {
                M_Session.id_session = 0;
                M_Session.session_name = "";
                M_Session.session_status = false;
                controller_main_frame.controller_landing_page = new C_Landing_Page(controller_main_frame);
            }
        }

        public void reset_button_focus()
        {
            main_Menu.Dashboard.BackgroundImage = Properties.Resources.Dashboard;
            main_Menu.Transaksi.BackgroundImage = Properties.Resources.Transaksi;
            main_Menu.Pelanggan.BackgroundImage = Properties.Resources.Pelanggan;
            main_Menu.Layanan.BackgroundImage = Properties.Resources.Layanan;
        }
    }
}
