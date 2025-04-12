using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Laprak
{
    class Karyawan
    {
        private string jenis_karyawan;
        private string id;
        private double gaji_pokok;
        public string Jenis_Karyawan
        {
            get { return jenis_karyawan; }
            set { jenis_karyawan = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Gaji_Pokok
        {
            get { return gaji_pokok; }
            set { gaji_pokok = value; }
        }
        public virtual double HitungGaji()
        {
            return gaji_pokok;
        }
    }
    class KaryawanTetap : Karyawan
    {
        public override double HitungGaji()
        {
            return Gaji_Pokok + 500000;
        }
    }
    class KaryawanKontrak : Karyawan
    {
        public override double HitungGaji()
        {
            return Gaji_Pokok - 200000;
        }
    }
    class KaryawanMagang : Karyawan
    {
        public override double HitungGaji()
        {
            return Gaji_Pokok;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Selamat datang di program penghitung gaji karyawan\n");
            Karyawan karyawan = new Karyawan();
            while (true)
            {
                while (true)
                {
                    Console.Write("Silahkan masukkan jenis karyawannya (karyawan tetap, karyawan kontrak, karyawan magang) : ");
                    string nama = Console.ReadLine().ToLower();
                    if (nama == "karyawan tetap")
                    {
                        karyawan = new KaryawanTetap();
                        karyawan.Jenis_Karyawan = nama;
                        break;
                    }
                    else if (nama == "karyawan kontrak")
                    {
                        karyawan = new KaryawanKontrak();
                        karyawan.Jenis_Karyawan = nama;
                        break;
                    }
                    else if (nama == "karyawan magang")
                    {
                        karyawan = new KaryawanMagang();
                        karyawan.Jenis_Karyawan = nama;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yang anda masukkan tidak sesuai, silahkan ulangi");
                    }
                }
                while (true)
                {
                    Console.Write("Silahkan masukkan id karyawan : ");
                    string id = Console.ReadLine();
                    if (id == "")
                    {
                        Console.WriteLine("Anda tidak memasukkan apa-apa");
                    }
                    else
                    {
                        karyawan.Id = id;
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Silahkan masukkan gaji pokoknya : ");
                    string input = Console.ReadLine();
                    if (input == "")
                    {
                        Console.WriteLine("Anda tidak memasukkan apa-apa");
                    }
                    else
                    {
                        double gaji_pokok = Convert.ToDouble(input);
                        karyawan.Gaji_Pokok = gaji_pokok;
                        break;
                    }
                }
                Console.WriteLine($"\nJenis karyawan \t: {karyawan.Jenis_Karyawan}");
                Console.WriteLine($"Id karyawan \t: {karyawan.Id}");
                Console.WriteLine($"Gaji karyawan \t: {karyawan.HitungGaji()}");
                Console.Write("\nApakah Anda ingin menghitung gaji karyawan lain? (ya/tidak): ");
                string pilihan = Console.ReadLine().ToLower();
                if (pilihan == "tidak")
                {
                    Console.WriteLine("Terima kasih telah menggunakan program ini. Sampai jumpa!/n");
                    break; 
                }
                else if (pilihan != "ya")
                {
                    Console.WriteLine("Input tidak valid, program berhenti./n");
                    break; 
                }
            }
        }
    }
}
