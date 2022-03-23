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
                cm.ExecuteNonQuery();

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
