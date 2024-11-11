using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Pet_Care.Model
{
    public class M_Transaksi : M_Connection, IModel
    {
        public List<object> Get()
        {
            NpgsqlDataReader data = Execute_With_Return("Select transaksi_id, TO_CHAR(tanggal_transaksi,'DD.MM.YYYY HH24:MI:SS') as tanggal,nama,nama_hewan,foto_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi from transaksi t join Pelanggan p on t.pelanggan_id = p.pelanggan_id");

            List<object> list = new List<object>();
            while (data.Read())
            {
                Data_Transaksi data_Transaksi = new Data_Transaksi
                {
                    id = (int)data["transaksi_id"],
                    Waktu = data["tanggal"].ToString(),
                    Nama_Pelanggan = data["tanggal"].ToString(),
                    Nama_Kucing = data["nama_hewan"].ToString(),
                    Foto_Kucing = (byte[])data["foto_hewan"],
                    durasi_penitipan = data["Durasi_Penitipan"].ToString(),
                    Nomor_hp = data["nomor_hp"].ToString(),
                    Alamat = data["alamat"].ToString()
                };
                list.Add(data_Transaksi);
            }
            conn.Close();
            return list;
        }
        public List<object> Get(string time)
        {
            NpgsqlDataReader data = Execute_With_Return("Select transaksi_id, TO_CHAR(tanggal_transaksi,'DD.MM.YYYY HH24:MI:SS') as tanggal,nama,nama_hewan,foto_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi from transaksi t join Pelanggan p on t.pelanggan_id = p.pelanggan_id where TO_CHAR(tanggal_transaksi,'DD-MM-YYYY') = TO_CHAR(now(),'DD-MM-YYYY')");
            List<object> list = new List<object>();
            while (data.Read())
            {
                Data_Transaksi data_Transaksi = new Data_Transaksi
                {
                    id = (int)data["transaksi_id"],
                    Waktu = data["tanggal"].ToString(),
                    Nama_Pelanggan = data["tanggal"].ToString(),
                    Nama_Kucing = data["nama_hewan"].ToString(),
                    Foto_Kucing = (byte[])data["foto_hewan"],
                    durasi_penitipan = data["Durasi_Penitipan"].ToString(),
                    Nomor_hp = data["nomor_hp"].ToString(),
                    Alamat = data["alamat"].ToString()
                };
                list.Add(data_Transaksi);
            }
            conn.Close();
            return list;
        }
        public  Data_Transaksi Get_detail(int id)
        {
            NpgsqlDataReader data = Execute_With_Return("Select t.transaksi_id, TO_CHAR(tanggal_transaksi,'DD.MM.YYYY HH24:MI:SS') as tanggal,nama,nama_hewan,foto_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi,nama_pelayanan" +
                "from transaksi t " +
                "join Pelanggan p on t.pelanggan_id = p.pelanggan_id " +
                "join detail_transaksi dt on dt.transaksi_id = t.transaksi_id " +
                "join Pelayanan pl on pl.pelayanan_id = dt.pelayanan_id " +
                $"where t.transaksi_id = {id}");
            Data_Transaksi data_transaksi = new Data_Transaksi();
            data_transaksi.Layanan = new List<string>();

            while (data.Read()) 
            {
                data_transaksi.id = (int)data["transaksi_id"];
                data_transaksi.Waktu = data["tanggal"].ToString();
                data_transaksi.Nama_Pelanggan = data["tanggal"].ToString();
                data_transaksi.Nama_Kucing = data["nama_hewan"].ToString();
                data_transaksi.Foto_Kucing = (byte[])data["foto_hewan"];
                data_transaksi.durasi_penitipan = data["Durasi_Penitipan"].ToString();
                data_transaksi.Nomor_hp = data["nomor_hp"].ToString();
                data_transaksi.Alamat = data["alamat"].ToString();
                data_transaksi.Layanan.Add(data["nama_pelayanan"].ToString());
            }
            return data_transaksi;
        }

        public bool Insert(object obj)
        {
            Data_Transaksi data = obj as Data_Transaksi;
            return true;
        }

        public void Delete(int id)
        {
            Execute_No_Return($"Delete from transaksi where id = {id}");
            Execute_No_Return($"Delete from detail_transaksi where transaksi_id = {id}");
        }
        public bool Update(object obj, int id)
        {
            return true;
        }

        public double Get_Pendapatan()
        {
            NpgsqlDataReader reader = Execute_With_Return("select sum(nominal_transaksi) as total_transaksi from transaksi ");
            double nominal = 0;
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    nominal = 0;
                }
                else
                {
                    nominal = (double)reader["total_transaksi"];
                } 
            }
            conn.Close();
            return nominal;
        }
    }

    public class Data_Transaksi
    {
        public int id { get; set; }
        public string Waktu {  get; set; }
        public string Nama_Pelanggan {  get; set; }
        public string Nama_Kucing {  get; set; }
        public byte[] Foto_Kucing { get; set; }
        public string durasi_penitipan {  get; set; }
        public string Nomor_hp { get; set; }
        public string Alamat {  get; set; }
        public List<string> Layanan { get; set; }
    }
}
