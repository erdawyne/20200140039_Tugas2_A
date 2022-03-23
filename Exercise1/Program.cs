using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise1
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null; 
            try
            {
                con = new SqlConnection("data source=LAPTOP-EED9RP81\\ERDAWYNE;database=ERDA;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mall (nama_ruko varchar(20) not null primary key," +
                    "Nama_pemilik varchar(30), id_pemilik string(20), alamat string(30), phone int))", con);

                SqlCommand cm = new SqlCommand("create table Sewa (id_sewa (varchar(10) not null primary key," +
                    "tgl_booking date, uang_muka money, biaya_sewa money, status varchar(15))", con);

                SqlCommand cm = new SqlCommand("create table Operasi (masa_kontrak varchar(20) not null primary key," +
                    "tgl_selesai date, id_sewa varchar(10))", con);

                SqlCommand cm = new SqlCommand("create table Pembayaran (id_pembayaran varchar(10) not null primary key," +
                    "tgl_bayar date, jml_bayar money, id_sewa varchar(10))", con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops,sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        
        }
        static void Main(string[] args)
        {
        }
    }
}
