using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care.Model
{
    public class Data_Transaksi
    {
        public int id { get; set; }
        public int Id_pelanggan { get; set; }
        public int id_akun { get; set; }
        public string Waktu { get; set; }
        public string Tele { get; set; }
        public string Tanggal { get; set; }
        public string Nama_Pelanggan { get; set; }
        public string Nama_Kucing { get; set; }
        public byte[] Foto_Kucing { get; set; }
        public string durasi_penitipan { get; set; }
        public string Nomor_hp { get; set; }
        public string Alamat { get; set; }
        public int nominal { get; set; }
        public string Metode_Pembayaran { get; set; }
        public string display_price { get; set; }
        public List<dynamic[]> Layanan { get; set; }
    }
}
