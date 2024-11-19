using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Pet_Care.Model
{
    public abstract class M_Connection
    {
        protected string addres = "Host=localhost;Username=postgres;Password=;Database=MeowInn";
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
                "Status_Pelanggan Bool Not Null Default true)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Pelayanan (" +
                "Pelayanan_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Nama_Pelayanan VARCHAR(20) NOT NULL," +
                "Harga_Pelayanan INTEGER NOT NULL," +
                "Deskripsi_Pelayanan TEXT," +
                "Foto Bytea," +
                "Status_Pelayanan Bool Not NUll Default true)");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Transaksi (" +
                "Transaksi_id serial NOT NULL UNIQUE PRIMARY KEY," +
                "Tanggal_transaksi TIMESTAMPTZ NOT NULL DEFAULT CURRENT_TIMESTAMP," +
                "Nama_hewan VARCHAR(20) NOT NULL," +
                "Foto_hewan Bytea NOT NULL," +
                "Durasi_Penitipan Integer Not Null," +
                "Nominal_transaksi INTEGER NOT NULL," +
                "Status_Penitiapan Bool Not NUll," +
                "Pelanggan_id integer NOT NULL," +
                "Akun_id integer NOT NULL," +
                "CONSTRAINT Akun_fk FOREIGN KEY ( Akun_id ) REFERENCES Akun ( Akun_id )," +
                "CONSTRAINT Pelanggan_fk FOREIGN KEY ( Pelanggan_id ) REFERENCES pelanggan ( Pelanggan_id ))");

            Execute_No_Return("CREATE TABLE IF NOT EXISTS Detail_Transaksi (Quantity INTEGER NOT NULL," +
                "Pelayanan_id integer NOT NULL," +
                "Transaksi_id integer NOT NULL," +
                "CONSTRAINT pelayanan_fk FOREIGN KEY ( pelayanan_id ) REFERENCES pelayanan ( pelayanan_id )," +
                "CONSTRAINT transaksi_fk FOREIGN KEY ( transaksi_id ) REFERENCES transaksi ( transaksi_id ))");
        }

        public void Execute_No_Return(string Querry)
        {
            conn = new NpgsqlConnection(addres);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Querry;
            cmd.ExecuteNonQuery();
        }

        public void Execute_No_Return(NpgsqlCommand command)
        {
            conn = new NpgsqlConnection(addres);
            command.Connection = conn;
            command.ExecuteNonQuery();
        }

        public NpgsqlDataReader Execute_With_Return(string Querry) {
            conn = new NpgsqlConnection(addres);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Querry;
            NpgsqlDataReader Data = cmd.ExecuteReader();
            return Data;
        }

        public object Execute_Single_Return(string querry)
        {
            conn = new NpgsqlConnection(addres);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = querry;
            object Data = cmd.ExecuteScalar();
            return Data;
        }
    }
}
