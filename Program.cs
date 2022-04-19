using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemrograman4269
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Paijo", 190302123, 4000000);
            Karyawan karyawan2 = new Karyawan("Jono", 190302124, 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.Data();
            Console.Write("2 "); karyawan2.Data();
            Console.WriteLine();

            karyawan1.Tambah();
            karyawan2.Tambah();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.Data();
            Console.Write("2 "); karyawan2.Data();
        }
    }
}
