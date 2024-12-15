using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable data = Execute_With_Return($"SELECT * From Pelayanan where status_pelayanan = true order by Pelayanan_id asc");
            List<object> list = new List<object>();
            for (int i=0;i < data.Rows.Count;i++)
            {
                Data_Layanan data_Layanan = new Data_Layanan
                {
                    id = (int)data.Rows[i]["Pelayanan_id"],
                    name = data.Rows[i]["Nama_Pelayanan"].ToString(),
                    harga = (int)data.Rows[i]["Harga_Pelayanan"],
                    quantity_berdasarkan_hari = (bool)data.Rows[i]["quantity_berdasarkan_hari"],
                };
                data_Layanan.display_price = $"Rp{data_Layanan.harga.ToString("n", CultureInfo.GetCultureInfo("id-ID"))}";
                list.Add(data_Layanan);
            }
            //Conn.Close();
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
            string querry = $"UPDATE Pelayanan set nama_pelayanan = '{data_Layanan.name}', harga_pelayanan = {data_Layanan.harga},  quantity_berdasarkan_hari = {data_Layanan.quantity_berdasarkan_hari} where pelayanan_id = {data_Layanan.id}";
            Execute_No_Return(querry);
        }
    }
}
