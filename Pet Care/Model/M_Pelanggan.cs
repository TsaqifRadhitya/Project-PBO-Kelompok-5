using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Pet_Care.Model
{
    public class M_Pelanggan : M_Connection, IModel
    {
        public List<object> Get()
        {
            DataTable data = Execute_With_Return("Select * from Pelanggan where Status_Pelanggan = true");
            List<object> daftar_mahasiswa = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Pelanngan pelanggan = new Data_Pelanngan
                {
                    ID = (int)data.Rows[i]["pelanggan_id"],
                    Name = data.Rows[i]["nama"].ToString(),
                    Nomor_HP = data.Rows[i]["nomor_hp"].ToString(),
                    Alamat = data.Rows[i]["alamat"].ToString(),
                    Email = data.Rows[i]["Email"].ToString()
                };
                daftar_mahasiswa.Add(pelanggan);
            }
            return daftar_mahasiswa;
        }
        public List<object> Get(string keyword)
        {
            DataTable data = Execute_With_Return($"Select * from Pelanggan where Status_Pelanggan = true AND (nama ilike '%{keyword}%' OR nomor_hp ilike '%{keyword}%' OR alamat ilike '%{keyword}%')");
            List<object> daftar_mahasiswa = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Pelanngan pelanggan = new Data_Pelanngan
                {
                    ID = (int)data.Rows[i]["pelanggan_id"],
                    Name = data.Rows[i]["nama"].ToString(),
                    Nomor_HP = data.Rows[i]["nomor_hp"].ToString(),
                    Alamat = data.Rows[i]["alamat"].ToString(),
                    Email = data.Rows[i]["Email"].ToString()
                };
                daftar_mahasiswa.Add(pelanggan);
            }
            return daftar_mahasiswa;
        }
        public void Insert(object obj) { }
        public int insert(object obj)
        {
            Data_Pelanngan data = obj as Data_Pelanngan;
            return (int)Execute_With_Return($"Insert Into Pelanggan(nama,nomor_hp,alamat,Email) Values ('{data.Name}','{data.Nomor_HP}','{data.Alamat}','{data.Email}') Returning pelanggan_id").Rows[0]["pelanggan_id"];
        }

        public void Delete(int id)
        {
            Execute_No_Return($"UPDATE Pelanggan Set Status_Pelanggan = false where pelanggan_id = {id}");
        }

        public void Update(object obj,int id)
        {
            Data_Pelanngan data = obj as Data_Pelanngan ;
            Execute_No_Return($"UPDATE Pelanggan set nama = '{data.Name}',nomor_hp = '{data.Nomor_HP}',alamat = '{data.Alamat}',Email = '{data.Email}' where pelanggan_id = {id}");
        }
    }

    public class Data_Pelanngan
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Nomor_HP { get; set; }
        public string Alamat {  get; set; }
        public string Email {  get; set; }
    }
}
