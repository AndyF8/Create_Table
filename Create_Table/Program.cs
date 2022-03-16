using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table
{
    class Program
    {
        //Memanggil method CreateTable kedalam method Main
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        //Membuat method untuk operasi pembuatan tabel baru
        public void CreateTable()
        {
            //Deklarasi objek baru bernama "con" dengan menggunakan class "SqlConnection"
            SqlConnection con = null;
            
            //Membuat try-catch statement
            try
            {
                //Mengisi object "con" dengan ConnectionString
                con = new SqlConnection("data source = ANDY-DAFFA;database = ProdiTI;Integrated Security = TRUE");
                con.Open();

                //Membuat objek baru bernama "cm" menggunakan class SqlCommand
                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                //Membuat baris kode untuk menampilkan pemberitahuan jika tabel berhasil dibuat
                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();

            }
            catch (Exception e)
            {
               //Membuat baris kode untuk menampilkan pemberitahuan jika tabel gagal dibuat
                Console.WriteLine("ada yang salah." + e);
                Console.ReadKey();
            }
            finally {
                con.Close();
            

            }
            
            

  
            
        }
    }
}
