using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pet_Care.Model
{
    public class M_Layanan : M_Connection, IModel
    {
        public List<object> Get()
        {
            NpgsqlDataReader data = Execute_With_Return($"SELECT * From Pelayanan");
            List<object> list = new List<object>();
            while (data.Read())
            {
                Data_Layanan data_Layanan = new Data_Layanan
                {
                    id = (int)data["Pelayanan_id"],
                    name = data["Nama_Pelayanan"].ToString(),
                    harga = (double)data["Harga_Pelayanan"],
                    deskripsi = data["Deskripsi_Pelayanan"].ToString()
                };
                if (data["foto"] != DBNull.Value)
                {
                    data_Layanan.foto = (byte[])data["foto"];
                }
                list.Add(data_Layanan);
            }
            conn.Close();
            return list;
        }

        public bool Insert(object data)
        {
            Data_Layanan data_layanan = data as Data_Layanan;
            if (string.IsNullOrEmpty(data_layanan.deskripsi) && data_layanan.foto == Array.Empty<byte>()) 
            {
                Execute_No_Return($"INSERT INTO Pelayanan(nama_pelayanan,harga_pelayanan) Values ('{data_layanan.name}',{data_layanan.harga})");
            }else if (string.IsNullOrEmpty(data_layanan.deskripsi))
            {
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO Pelayanan(nama_pelayanan,harga_pelayanan,foto) Values ('{data_layanan.name}',{data_layanan.harga},@foto)";
                cmd.Parameters.AddWithValue("@foto",NpgsqlTypes.NpgsqlDbType.Bytea,data_layanan.foto);
                Execute_No_Return(cmd);
            }
            else
            {
                Execute_No_Return($"INSERT INTO Pelayanan(nama_pelayanan,harga_pelayanan,Deskripsi_Pelayanan) Values ('{data_layanan.name}',{data_layanan.harga},'{data_layanan.deskripsi}')");
            }
            return true;
        }

        public void Delete(int ID)
        {
            Execute_No_Return($"DELETE FROM Pelayanan where pelayanan_id = {ID}");
        }

        public bool Update(object obj, int id)
        {
            Data_Layanan data_Layanan = obj as Data_Layanan;
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = $"UPDATE Pelayanan set nama_pelayanan = '{data_Layanan.name}', harga_pelayanan = {data_Layanan.harga}, deskripsi_pelayanan = '{data_Layanan.deskripsi}',foto = @foto where pelayanan_id = {data_Layanan.id}";
            cmd.Parameters.AddWithValue("@foto",NpgsqlTypes.NpgsqlDbType.Bytea, data_Layanan.foto);
            Execute_No_Return(cmd);
            return true;
        }
    }

    public class Data_Layanan
    {
        public int id { get; set; }
        public string name { get; set; }
        public double harga { get; set; }
        public string deskripsi { get; set; }
        public byte[] foto { get; set; }
    }
}
