﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Pet_Care.Model
{
    public class M_Akun : M_Connection, IModel
    {
        public M_Akun()
        {
            Setup();
           
        }
        public List<object> Get()
        {
            return new List<object>();
        }

        public void Get(string username, string password)
        {
            DataTable data = Execute_With_Return($"SELECT akun_id,nama_lengkap from akun where username = '{username}' and password = '{password}'");
            if (data.Rows.Count == 1) {
                M_Session.session_name = data.Rows[0]["nama_lengkap"].ToString();
                M_Session.id_session = (int)data.Rows[0]["akun_id"];
                M_Session.session_status = true;
            }
        }

        public void Insert(object item)
        {
            Akun akun = item as Akun;
            Execute_No_Return($"INSERT INTO Akun(nama_lengkap,username,password,email,nomor_hp) Values ('{akun.Name}','{akun.Username}','{akun.Password}','{akun.Email}','{akun.Nomor_Hp}')");
        }

        public void Delete(int ID) 
        { 

        }

        public void Update(object data,int id) 
        { 
        }

    }
}


