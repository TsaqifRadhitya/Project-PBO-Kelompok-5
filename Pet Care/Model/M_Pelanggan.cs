using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public class M_Pelanggan : M_Connection, IModel
    {
        public List<object> Get()
        {
            return new List<object>();
        }

        public bool Insert(object obj)
        {
            return false;
        }

        public void Delete(int id)
        {

        }

        public bool Update(object obj,int id)
        {
            return true;
        }
    }

    public class Data_Pelanngan
    {

    }
}
