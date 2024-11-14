using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_Layanan
    {
        C_MainMenu C_MainMenu;
        V_Layanan V_Layanan;
        public C_Layanan(C_MainMenu controller) 
        { 
            C_MainMenu = controller;
            V_Layanan = new V_Layanan(this);
            controller.move_view(V_Layanan);
        }
    }
}
