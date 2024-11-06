using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public class M_Akun : M_Connection, IM_Connection
    {
        public M_Akun()
        {
            Setup();
           
        }
        public void Get()
        {

        }

        public void Get(string username, string password)
        {

        }

        public bool Insert(object item)
        {
            return false;
        }

        public void Delete(int ID) 
        { 

        }

        public bool Update(object data,int id) 
        { 
            return true;
        }

    }


    public class Akun
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Nomor_Hp {  get; set; }
    }
}


