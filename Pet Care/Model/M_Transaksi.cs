using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            DataTable data = Execute_With_Return("Select transaksi_id, TO_CHAR(tanggal_transaksi,'DD-MM-YYYY') as tanggal,nama,nama_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi,metode_pembayaran from transaksi t join Pelanggan p on t.pelanggan_id = p.pelanggan_id where status_penitipan = true order by tanggal_transaksi desc");
            
            List<object> list = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Transaksi data_Transaksi = new Data_Transaksi
                {   
                    id = (int)data.Rows[i]["transaksi_id"],
                    Tanggal = data.Rows[i]["tanggal"].ToString(),
                    Nama_Pelanggan = data.Rows[i]["nama"].ToString(),
                    Nama_Kucing = data.Rows[i]["nama_hewan"].ToString(),
                    durasi_penitipan = $"{data.Rows[i]["Durasi_Penitipan"].ToString()} Hari",
                    Nomor_hp = data.Rows[i]["nomor_hp"].ToString(),
                    Alamat = data.Rows[i]["alamat"].ToString(),
                    Metode_Pembayaran = data.Rows[i]["metode_pembayaran"].ToString(),
                    nominal = (int)data.Rows[i]["nominal_transaksi"],
                };
                data_Transaksi.display_price = "Rp" + ((int)data.Rows[i]["nominal_transaksi"]).ToString("n2", CultureInfo.GetCultureInfo("id-ID"));
                list.Add(data_Transaksi);
            }
            return list;
        }
        public List<Data_Transaksi> Get_with_photo()
        {
            DataTable data = Execute_With_Return("Select transaksi_id, TO_CHAR(tanggal_transaksi,'DD-MM-YYYY') as tanggal,nama,nama_hewan,foto_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi,metode_pembayaran,telegram from transaksi t join Pelanggan p on t.pelanggan_id = p.pelanggan_id where status_penitipan = true order by tanggal_transaksi desc");

            List<Data_Transaksi> list = new List<Data_Transaksi>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Transaksi data_Transaksi = new Data_Transaksi
                {
                    id = (int)data.Rows[i]["transaksi_id"],
                    Tanggal = data.Rows[i]["tanggal"].ToString(),
                    Nama_Pelanggan = data.Rows[i]["nama"].ToString(),
                    Nama_Kucing = data.Rows[i]["nama_hewan"].ToString(),
                    Foto_Kucing = (byte[])data.Rows[i]["foto_hewan"],
                    durasi_penitipan = $"{data.Rows[i]["Durasi_Penitipan"].ToString()} Hari",
                    Nomor_hp = data.Rows[i]["nomor_hp"].ToString(),
                    Alamat = data.Rows[i]["alamat"].ToString(),
                    Metode_Pembayaran = data.Rows[i]["metode_pembayaran"].ToString(),
                    nominal = (int)data.Rows[i]["nominal_transaksi"],
                    Tele = data.Rows[i]["telegram"].ToString()
                };
                list.Add(data_Transaksi);
            }
            return list;
        }
        public List<object> Get_riwayat()
        {
            DataTable data = Execute_With_Return("Select transaksi_id, TO_CHAR(tanggal_transaksi,'DD-MM-YYYY') as tanggal,nama,nama_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi,metode_pembayaran from transaksi t join Pelanggan p on t.pelanggan_id = p.pelanggan_id where status_penitipan = false order by tanggal_transaksi desc");

            List<object> list = new List<object>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Data_Transaksi data_Transaksi = new Data_Transaksi
                {
                    id = (int)data.Rows[i]["transaksi_id"],
                    Tanggal = data.Rows[i]["tanggal"].ToString(),
                    Nama_Pelanggan = data.Rows[i]["nama"].ToString(),
                    Nama_Kucing = data.Rows[i]["nama_hewan"].ToString(),
                    durasi_penitipan = $"{data.Rows[i]["Durasi_Penitipan"].ToString()} Hari",
                    Nomor_hp = data.Rows[i]["nomor_hp"].ToString(),
                    Alamat = data.Rows[i]["alamat"].ToString(),
                    Metode_Pembayaran = data.Rows[i]["metode_pembayaran"].ToString(),
                    display_price = $"Rp{((int)data.Rows[i]["nominal_transaksi"]).ToString("n2", CultureInfo.GetCultureInfo("id-ID"))}"
                };
                list.Add(data_Transaksi);
            }
            return list;
        }
        public Data_Transaksi Get_detail(int id)
        {
            DataTable data = Execute_With_Return("Select t.transaksi_id,harga ,TO_CHAR(tanggal_transaksi,'DD/MM/YYYY, HH24:MI') as tanggal,nama,nama_hewan,Durasi_Penitipan,nomor_hp,alamat,nominal_transaksi,nama_pelayanan,quantity,metode_pembayaran " +
                "from transaksi t " +
                "join Pelanggan p on t.pelanggan_id = p.pelanggan_id " +
                "join detail_transaksi dt on dt.transaksi_id = t.transaksi_id " +
                "join Pelayanan pl on pl.pelayanan_id = dt.pelayanan_id " +
                $"where t.transaksi_id = {id}");
            Data_Transaksi data_transaksi = new Data_Transaksi();
            data_transaksi.Layanan = new List<dynamic[]>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                data_transaksi.id = (int)data.Rows[i]["transaksi_id"];
                data_transaksi.Tanggal = data.Rows[i]["tanggal"].ToString();
                data_transaksi.Nama_Pelanggan = data.Rows[i]["nama"].ToString();
                data_transaksi.Nama_Kucing = data.Rows[i]["nama_hewan"].ToString();
                data_transaksi.durasi_penitipan = $"{data.Rows[i]["Durasi_Penitipan"].ToString()} Hari";
                data_transaksi.Nomor_hp = data.Rows[i]["nomor_hp"].ToString();
                data_transaksi.Alamat = data.Rows[i]["alamat"].ToString();
                data_transaksi.Metode_Pembayaran =  data.Rows[i]["metode_pembayaran"].ToString();
                data_transaksi.Layanan.Add([data.Rows[i]["nama_pelayanan"].ToString(), (int)data.Rows[i]["quantity"],"Rp"+((int)data.Rows[i]["harga"]* (int)data.Rows[i]["quantity"]).ToString("n2", CultureInfo.GetCultureInfo("id-ID"))]);
                data_transaksi.nominal = (int)data.Rows[i]["nominal_transaksi"];
            }
            return data_transaksi;
        }
        public List<Data_Transaksi> Get_Foto_Kucing()
        {
            DataTable data = Execute_With_Return("Select nama_hewan,foto_hewan from transaksi where status_penitipan = false");
            List<Data_Transaksi> hasil = new List<Data_Transaksi>();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                hasil.Add(new Data_Transaksi
                {
                    Nama_Kucing = data.Rows[i]["nama_hewan"].ToString(),
                    Foto_Kucing = (byte[])data.Rows[i]["foto_hewan"]
                });
            }
            return hasil;
        }

        public void Insert(object obj)
        {
            Data_Transaksi data = obj as Data_Transaksi;
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = $"INSERT INTO TRANSAKSI(nama_hewan,foto_hewan,durasi_penitipan,nominal_transaksi,pelanggan_id,akun_id,metode_pembayaran) values ('{data.Nama_Kucing}',@foto,{data.durasi_penitipan},{data.nominal},{data.Id_pelanggan},{data.id_akun},'{data.Metode_Pembayaran}') RETURNING Transaksi_id";
            cmd.Parameters.AddWithValue("@foto",NpgsqlTypes.NpgsqlDbType.Bytea, data.Foto_Kucing);
            int id_transaksi = (int) Execute_With_Return(cmd).Rows[0]["Transaksi_id"];
            string querry_detail  = "INSERT INTO detail_transaksi(quantity,pelayanan_id,harga,transaksi_id) Values";
            for (int i = 0;i < data.Layanan.Count;i++)
            {
                querry_detail += $"({(int)data.Layanan[i][0]},{(int)data.Layanan[i][1]},{data.Layanan[i][4]},{id_transaksi})";
                if (data.Layanan.Count > 0 && data.Layanan.Count - 1 != i) querry_detail += ',';
            }
            Execute_No_Return(querry_detail);
        }

        public void Delete(int id)
        {
            Execute_No_Return($"Delete from detail_transaksi where transaksi_id = {id}");
            Execute_No_Return($"Delete from transaksi where Transaksi_id = {id}");
        }
        public void Update(object obj, int id)
        {
            Data_Transaksi data = obj as Data_Transaksi;
            Execute_No_Return($"UPDATE TRANSAKSI SET STATUS_PENITIPAN = false where transaksi_id = {data.id}");
        }

        public object Get_Pendapatan()
        {
            return Execute_With_Return("select sum(nominal_transaksi) as total_transaksi from transaksi where TO_CHAR(tanggal_transaksi,'DD-MM-YYYY') = TO_CHAR(now(),'DD-MM-YYYY')").Rows[0]["total_transaksi"];
        }
    }

    public class Data_Transaksi
    {
        public int id { get; set; }
        public int Id_pelanggan {  get; set; }
        public  int id_akun {  get; set; }
        public string Waktu {  get; set; }
        public string Tele {  get; set; }   
        public string Tanggal {  get; set; }
        public string Nama_Pelanggan {  get; set; }
        public string Nama_Kucing {  get; set; }
        public byte[] Foto_Kucing { get; set; }
        public string durasi_penitipan {  get; set; }
        public string Nomor_hp { get; set; }
        public string Alamat {  get; set; }
        public int nominal {  get; set; }
        public string Metode_Pembayaran {  get; set; }
        public string display_price {  get; set; }
        public List<dynamic[]> Layanan { get; set; }
    }
}
