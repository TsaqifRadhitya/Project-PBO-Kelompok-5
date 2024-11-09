﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public interface IM_Connection
    {
        public List<Object> Get();

        public bool Insert(object obj);

        public void Delete (int id);

        public bool Update(object obj,int id);
    }
}