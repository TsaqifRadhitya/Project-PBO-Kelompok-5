using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Pet_Care.Model
{
    public class M_Connection
    {
        string addres = "Host=localhost;Username=postgres;Password=;Database=";
        protected NpgsqlConnection conn;
        public void Setup()
        {
            Execute_No_Return("CREATE TABLE IF NOT EXISTS akun (" +
                "Akun_id  serial NOT NULL UNIQUE PRIMARY KEY," +
                "Username VARCHAR(10) NOT NULL UNIQUE," +
                "Password VARCHAR(20) NOT NULL ," +
                "Email    VARCHAR(50) NOT NULL UNIQUE," +
                "Nomor_Hp VARCHAR(13) NOT NULL UNIQUE)");

            Execute_With_Return("CREATE TABLE IF NOT EXISTS Pelanggan (" +
                "Pelanggan_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Nama VARCHAR(20) NOT NULL," +
                "Nomor_hp VARCHAR(13) NOT NULL," +
                "Alamat VARCHAR(30) NOT NULL)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Pelayanan (" +
                "Pelayanan_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Nama_Pelayanan VARCHAR(20) NOT NULL," +
                "Harga_Pelayanan INTEGER NOT NULL," +
                "Deskripsi_Pelayanan TEXT)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Transaksi (" +
                "Transaksi_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Tanggal_transaksi DATE NOT NULL," +
                "Waktu_transaksi DATE NOT NULL," +
                "Nama_hewan VARCHAR(20) NOT NULL," +
                "Foto_hewan Bytea NOT NULL," +
                "Nominal_transaksi INTEGER NOT NULL," +
                "Status_penitipan BOOL NOT NULL," +
                "Status Pembayaran BOOL NOT NULL,"+
                "Foto_Bukti_Pembayaran Bytea," +
                "Pelanggan_id integer NOT NULL,Akun_id integer NOT NULL," +
                "CONSTRAINT Akun_fk FOREIGN KEY ( Akun_id ) REFERENCES Akun ( Akun_id )," +
                "CONSTRAINT Pelanggan_fk FOREIGN KEY ( Pelanggan_id ) REFERENCES pelanggan ( Pelanggan_id ))");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Detail_Transaksi (Quantity INTEGER NOT NULL," +
                "Pelayanan_id integer NOT NULL," +
                "Transaksi_id integer NOT NULL," +
                "CONSTRAINT pelayanan_fk FOREIGN KEY ( pelayanan_id ) REFERENCES pelayanan ( pelayanan_id )," +
                "CONSTRAINT transaksi_fk FOREIGN KEY ( transaksi_id ) REFERENCES transaksi ( transaksi_id ))");
        }

        public bool Execute_No_Return(string Querry)
        {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Querry;
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            } 
        }
        public NpgsqlDataReader Execute_With_Return(string Querry) {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Querry;
            NpgsqlDataReader Data = cmd.ExecuteReader();
            return Data;
        }
    }
}
