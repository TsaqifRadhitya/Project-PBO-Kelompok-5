using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public class M_Layanan : M_Connection, IM_Connection
    {
        public List<object> Get()
        {
            List<object> list = new List<object>();
            return new List<object>();
        }

        public bool Insert(object ob)
        {
            return true;
        }

        public void Delete(int ID)
        {

        }

        public bool Update(object obj, int id)
        {
            return true;
        }
    }

    public class Data_Layanan
    {
        public int id { get; set; }
        public string name { get; set; }
        public int harga { get; set; }
        public string deskripsi { get; set; }
        public byte[] foto { get; set; }
    }
}
