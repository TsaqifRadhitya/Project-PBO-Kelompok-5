using System;
using System.Collections.Generic;
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
            NpgsqlDataReader data = Execute_With_Return("Select * from Pelanggan where Status_Pelanggan = true");
            List<object> daftar_mahasiswa = new List<object>();
            while (data.Read()) 
            {
                Data_Pelanngan pelanggan = new Data_Pelanngan
                {
                    ID = (int)data["pelanggan_id"],
                    Name = data["nama"].ToString(),
                    Nomor_HP = data["nomor_hp"].ToString(),
                    Alamat = data["alamat"].ToString()
                };
                daftar_mahasiswa.Add(pelanggan);
            }
            return daftar_mahasiswa;
        }
        public List<object> Get(string keyword)
        {
            NpgsqlDataReader data = Execute_With_Return($"Select * from Pelanggan where Status_Pelanggan = true AND (nama ilike '%{keyword}%' OR nomor_hp ilike '%{keyword}%' OR alamat ilike '%{keyword}%')");
            List<object> daftar_mahasiswa = new List<object>();
            while (data.Read())
            {
                Data_Pelanngan pelanggan = new Data_Pelanngan
                {
                    ID = (int)data["pelanggan_id"],
                    Name = data["nama"].ToString(),
                    Nomor_HP = data["nomor_hp"].ToString(),
                    Alamat = data["alamat"].ToString()
                };
                daftar_mahasiswa.Add(pelanggan);
            }
            return daftar_mahasiswa;
        }

        public void Insert(object obj)
        {
            Data_Pelanngan data = obj as Data_Pelanngan;
            Execute_No_Return($"Insert Into Pelanggan(nama,nomor_hp,alamat) Values ('{data.Name}','{data.Nomor_HP}','{data.Alamat}')");
        }

        public void Delete(int id)
        {
            Execute_No_Return($"UPDATE Pelanggan Set Status_Pelanggan = false where pelanggan_id = {id}");
        }

        public void Update(object obj,int id)
        {
            Data_Pelanngan data = obj as Data_Pelanngan ;
            Execute_No_Return($"UPDATE Pelanggan set nama = '{data.Name}',nomor_hp = '{data.Nomor_HP}',alamat = '{data.Alamat}' where pelanggan_id = {id}");
        }
    }

    public class Data_Pelanngan
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Nomor_HP { get; set; }
        public string Alamat {  get; set; }
    }
}
