using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Npgsql;

namespace Pet_Care.Model
{
    public abstract class M_Connection
    {
        protected string addres = Env.GetString("DATABASE");
        private NpgsqlConnection Conn;
        protected NpgsqlConnection conn
        { 
            get {
                return this.Conn;
            } 
            set{
                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                    Conn = null;
                }
                Conn = value ; 
                Conn.Open();
            } 
        }
        public void Setup()
        {
            Execute_No_Return("CREATE TABLE IF NOT EXISTS akun (" +
                "Akun_id  serial NOT NULL UNIQUE PRIMARY KEY," +
                "Nama_Lengkap Varchar(50) NOT NULL,"+
                "Username VARCHAR(10) NOT NULL UNIQUE," +
                "Password VARCHAR(20) NOT NULL ," +
                "Email    VARCHAR(50) NOT NULL UNIQUE," +
                "Nomor_Hp VARCHAR(13) NOT NULL UNIQUE)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Pelanggan (" +
                "Pelanggan_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Nama VARCHAR(20) NOT NULL," +
                "Nomor_hp VARCHAR(13) NOT NULL UNIQUE," +
                "Alamat VARCHAR(30) NOT NULL," +
                "Email VARCHAR(50) UNIQUE NOT NULL," +
                "Telegram VARCHAR(20) UNIQUE NOT NULL," +
                "Status_Pelanggan Bool Not Null Default true)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Pelayanan (" +
                "Pelayanan_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Nama_Pelayanan VARCHAR(30) NOT NULL UNIQUE," +
                "Harga_Pelayanan INTEGER NOT NULL," +
                "Quantity_Berdasarkan_hari Bool Not Null," +
                "Status_Pelayanan Bool Not NUll Default true)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Transaksi (" +
                "Transaksi_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Tanggal_transaksi TIMESTAMPTZ NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                "Nama_hewan VARCHAR(20) NOT NULL," +
                "Foto_hewan Bytea NOT NULL," +
                "Durasi_Penitipan Integer Not Null," +
                "Nominal_transaksi INTEGER NOT NULL," +
                "Metode_Pembayaran VARCHAR(20) Not Null," +
                "Status_Penitipan Bool Not NUll default true," +
                "Pelanggan_id integer NOT NULL," +
                "Akun_id integer NOT NULL," +
                "CONSTRAINT Akun_fk FOREIGN KEY ( Akun_id ) REFERENCES Akun ( Akun_id )," +
                "CONSTRAINT Pelanggan_fk FOREIGN KEY ( Pelanggan_id ) REFERENCES pelanggan ( Pelanggan_id ))");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Detail_Transaksi (Quantity INTEGER NOT NULL," +
                "Pelayanan_id integer NOT NULL," +
                "harga integer not null," +
                "Transaksi_id integer NOT NULL," +
                "CONSTRAINT pelayanan_fk FOREIGN KEY ( pelayanan_id ) REFERENCES pelayanan ( pelayanan_id )," +
                "CONSTRAINT transaksi_fk FOREIGN KEY ( transaksi_id ) REFERENCES transaksi ( transaksi_id ))");
            try
            {
                Execute_No_Return("INSERT INTO PELAYANAN(Nama_Pelayanan,Harga_Pelayanan,Quantity_Berdasarkan_hari) Values ('Penitipan',50000,true)");
            }
            catch
            {

            }
        }

        public void Execute_No_Return(string Querry)
        {
            using(conn = new NpgsqlConnection(addres))
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Querry;
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable Execute_With_Return(string Querry) {
           using (conn = new NpgsqlConnection(addres))
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Querry;
                DataTable Data = new DataTable();
                Data.Load(cmd.ExecuteReader());
                return Data;
            }  
        }

        public DataTable Execute_With_Return(NpgsqlCommand Querry)
        {
            using (conn = new NpgsqlConnection(addres))
            {
                Querry.Connection = conn;
                DataTable Data = new DataTable();
                Data.Load(Querry.ExecuteReader());
                return Data;
            }
        }
    }
}
