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

                SqlCommand cm = new SqlCommand("create table Mall (nama_ruko varchar(20) not null primary key, nama_pemilik varchar(30), id_pemilik string(20), alamat string(30), phone int))" +

                ("create table Sewa(id_sewa(varchar(10) not null primary key, tgl_booking date, uang_muka money, biaya_sewa money, status varchar(15))" +

                ("create table Operasi (masa_kontrak varchar(20) not null primary key, tgl_selesai date, id_sewa varchar(10))" +

                ("create table Pembayaran (id_pembayaran varchar(10) not null primary key, tgl_bayar date, jml_bayar money, id_sewa varchar(10))", con);
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
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-EED9RP81\\ERDAWYNE;database=ERDA;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Mall (nama_ruko,nama_pemilik,id_pemilik_alamat,phone values('Hijabin','Tanjung','A1','Seyegan','0877222333')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik_alamat,phone values('Maskerin','Bowo','A2','Minggir','0813232890')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik_alamat,phone values('Fashion','Lisa','A3','Godean','0897364289')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik_alamat,phone values('Cooking Mom','Yati','A4','Turi','0853672484')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik_alamat,phone values('Boba Jam','Lala','A5','Gamping','0820439439')", con);








                    ("insert into Sewa (id_sewa,tgl_booking,uang_muka,biaya_sewa money,status values('SE01','20-03-2021','Rp. 500.000','Rp. 1.500.000','Kontrak')" + 

                    ("Insert into Operasi (masa_kontrak,tgl_selesai,id_sewa values ('1 Tahun','20-03-2022','SE01')" + 
                    
                    ("Insert into Pembayaran (id_pembayaran,tgl_bayar,jml_bayar,total_sewa,id_sewa values ('AA1','20-03-2021','Rp. 500.000','Rp. 6.000.000','SE01')" +
                    con);
            }
        }
    }
}
