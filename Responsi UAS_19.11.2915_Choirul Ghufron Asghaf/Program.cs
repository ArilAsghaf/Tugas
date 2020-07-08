using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: 
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine(" ");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            double nota, totalnota;
            string tanggal, customer, jenis;

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();
            Console.WriteLine("Nota : ");
            nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Tanggal : ");
            tanggal = Console.ReadLine();
            Console.WriteLine("Customer : ");
            customer = Console.ReadLine();
            Console.WriteLine("Jenis [T/K] : ");
            jenis = Console.ReadLine();
            Console.WriteLine("Total Nota : ");
            totalnota = int.Parse(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Nama = nama, Jenis = jenis, Total = total });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            bool ketemu = false;
            int hapus;
            int x = 0;

            Console.WriteLine("Hapus Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota: ");
            hapus = int.Parse(Console.ReadLine());
            foreach (Penjualan penjual in daftarPenjualan)
            {
                if (hapus == penjual.Nota)
                {
                    ketemu = true;
                    break;
                }
                x++;
            }
            if (ketemu)
            {
                daftarPenjualan.RemoveAt(x);
                Console.WriteLine("Data penjualan Berhasil di hapus");

            }
            else
            {
                Console.WriteLine("Data tidak ditemukan");
            }

                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (penjualan.Jenis == 'T' || penjualan.Jenis == 't')
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, Tunai, {4}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Total);
                }

                else if (penjualan.Jenis == 'K' || penjualan.Jenis == 'k')
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, Kredit, {4}", no, penjualan.Nota, penjualan.Tanggal, penjualan.Nama, penjualan.Total);
                }

                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
