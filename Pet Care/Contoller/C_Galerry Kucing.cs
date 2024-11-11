using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Care.View;

namespace Pet_Care.Contoller
{
    public class C_Galerry_Kucing
    {
        V_Gallery_Kucing controller;
        public C_Galerry_Kucing(V_Gallery_Kucing controller) 
        {
            this.controller = controller;
            load_photo();
        }

        public void load_photo()
        {

        }
    }
}
