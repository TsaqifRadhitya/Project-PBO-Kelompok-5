using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
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
                    harga = (int)data["Harga_Pelayanan"],
                    quantity_berdasarkan_hari = (bool)data[" quantity_berdasarkan_hari"],
                };
                data_Layanan.display_price = $"Rp{data_Layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
                list.Add(data_Layanan);
            }
            return list;
        }

        public void Insert(object data)
        {
            Data_Layanan data_layanan = data as Data_Layanan;
            Execute_No_Return($"INSERT INTO Pelayanan(nama_pelayanan,harga_pelayanan,quantity_berdasarkan_hari) Values ('{data_layanan.name}',{data_layanan.harga},{data_layanan.quantity_berdasarkan_hari})");
        }

        public void Delete(int ID)
        {
            Execute_No_Return($"Update Pelayanan Set Status_pelayanan = false where pelayanan_id = {ID}");
        }

        public void Update(object obj, int id)
        {
            Data_Layanan data_Layanan = obj as Data_Layanan;
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = $"UPDATE Pelayanan set nama_pelayanan = '{data_Layanan.name}', harga_pelayanan = {data_Layanan.harga},  quantity_berdasarkan_hari = {data_Layanan.quantity_berdasarkan_hari} where pelayanan_id = {data_Layanan.id}";
            Execute_No_Return(cmd);
        }
    }

    public class Data_Layanan
    {
        public int id { get; set; }
        public string name { get; set; }
        public int harga { get; set; }
        public string display_price { get; set; }
        public bool quantity_berdasarkan_hari {  get; set; }
    }
}
