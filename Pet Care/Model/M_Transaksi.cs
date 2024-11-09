using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public class M_Transaksi : M_Connection, IM_Connection
    {
        public List<object> Get()
        {
            List<object> list = new List<object>();
            Data_Transaksi data_Transaksi = new Data_Transaksi 
            { 
                Tanggal = "09 - 11- 2024",
                Jam = "23.59",
                Nama_Kucing = "Dori",
                Nama_Pelanggan = "Tsaqif",
                durasi_penitipan = "5 hari"
            };
            list.Add(data_Transaksi);
            list.Add(data_Transaksi);
            for(int i = 0; i <20; i++)
            {
                list.Add(data_Transaksi);
            }
            return list;
        }

        public bool Insert(object obj)
        {
            Data_Transaksi data = obj as Data_Transaksi;
            return true;
        }

        public void Delete(int id)
        {

        }
        public bool Update(object obj, int id)
        {
            return true;
        }
    }

    public class Data_Transaksi
    {
        public string Tanggal {  get; set; }
        public string Jam { get; set; }
        public string Nama_Pelanggan {  get; set; }
        public string Nama_Kucing {  get; set; }
        public string durasi_penitipan {  get; set; }
    }
}
