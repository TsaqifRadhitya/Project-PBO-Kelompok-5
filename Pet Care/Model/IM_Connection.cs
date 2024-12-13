using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public interface IModel
    {
        public List<object> Get();

        public void Insert(object obj);

        public void Delete (int id);

        public void Update(object obj,int id);
    }
}
 