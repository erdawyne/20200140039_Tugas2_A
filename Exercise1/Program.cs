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

                SqlCommand cm = new SqlCommand("create table Mall (nama_ruko varchar(20) not null primary key, nama_pemilik varchar(30), id_pemilik varchar(30), alamat varchar(20), phone int))" +

                ("create table Sewa(id_sewa varchar(10) not null primary key, tgl_booking date, uang_muka money, biaya_sewa money, statuss varchar(15))" +

                ("create table Operasi (masa_kontrak varchar(20) not null primary key, tgl_selesai date, id_sewa varchar(10))" +

                ("create table Pembayaran (id_pembayaran varchar(10) not null primary key, tgl_bayar date, id_sewa varchar(10))", con);
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

                SqlCommand cm = new SqlCommand("insert into Mall (nama_ruko,nama_pemilik,id_pemilik,alamat,phone) values('Hijabin','Tanjung','A1','Seyegan','0877222333')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik,alamat,phone) values('Maskerin','Bowo','A2','Minggir','0813232890')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik,alamat,phone) values('Fashion','Lisa','A3','Godean','0897364289')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik,alamat,phone) values('Cooking Mom','Yati','A4','Turi','0853672484')"
                    + ("insert into Mall (nama_ruko,nama_pemilik,id_pemilik,alamat,phone) values('Boba Jam','Lala','A5','Gamping','0820439439')"

                    +
                //Tabel Sewa
                    ("insert into Sewa (id_sewa,tgl_booking,uang_muka,biaya_sewa money,statuss) values('SE01','220-3-2-','500000',1500000','Kontrak')"
                    + ("insert into Sewa (id_sewa, tgl_booking, uang_muka, biaya_sewa money, statuss) values('SE02','2022-3-3','750000','1500000','Kontrak')"
                    + ("insert into Sewa (id_sewa, tgl_booking, uang_muka, biaya_sewa money, statuss) values('SE03','2021-12-10','500000','1500000','Kontrak')"
                    + ("insert into Sewa (id_sewa, tgl_booking, uang_muka, biaya_sewa money, statuss) values('SE04','2022-1-2','800000','1500000','Kontrak')"
                    + ("insert into Sewa (id_sewa, tgl_booking, uang_muka, biaya_sewa money, statuss) values('SE05','2022-3-3','500000','1500000','Kontrak')"

                    +
                //Tabel Operasi
                    ("Insert into Operasi (masa_kontrak,tgl_selesai,id_sewa) values ('1 Tahun','2020-03-20','SE01')"
                    + ("Insert into Operasi (masa_kontrak,tgl_selesai,id_sewa) values ('3 Bulan','2022-3-3','SE02')"
                    + ("Insert into Operasi (masa_kontrak,tgl_selesai,id_sewa) values ('2 Tahun','2024-12-10','SE03')"
                    + ("Insert into Operasi (masa_kontrak,tgl_selesai,id_sewa) values ('2 Tahun','2024-1-2','SE04')"
                    + ("Insert into Operasi (masa_kontrak,tgl_selesai,id_sewa) values ('1 Bulan','2022-4-3','SE05')"


                    +
                //Tabel Pembayaran
                ("Insert into Pembayaran (id_pembayaran,tgl_bayar,jml_bayar,id_sewa) values ('AA1','2021-03-20','500000','SE01')"
                + ("Insert into Pembayaran (id_pembayaran,tgl_bayar,jml_bayar,id_sewa) values ('AA2','2021-12-3','750000','SE02')"
                + ("Insert into Pembayaran (id_pembayaran,tgl_bayar,jml_bayar,id_sewa) values ('AA3','2021-12-10','500000','SE03')"
                + ("Insert into Pembayaran (id_pembayaran,tgl_bayar,jml_bayar,id_sewa) values ('AA4','2022-1-2','800000','SE04')"
                + ("Insert into Pembayaran (id_pembayaran,tgl_bayar,jml_bayar,id_sewa) values ('AA5','2022-3-3','500000','SE05')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Isi sukses dibuat!");
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
        
    }
}

