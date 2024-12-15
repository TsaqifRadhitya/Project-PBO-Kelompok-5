using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public class Data_Layanan
    {
        public int id { get; set; }
        public string name { get; set; }
        public int harga { get; set; }
        public string display_price { get; set; }
        public bool quantity_berdasarkan_hari { get; set; }
    }
}
