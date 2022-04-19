using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemrograman4269
{
    class Karyawan
    {
        public string Nama { get; set; }
        public int Nik { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nama, int nik, int gaji) 
        {
            Nama = nama;
            Nik = nik;
            GajiBulanan = gaji;
        }
        public void Data()
        {
            Console.WriteLine("{0} {1}      {2}", Nik, Nama, GajiBulanan); 
        }
        public void Tambah()
        {
            int tambah;

            tambah = GajiBulanan * 110;
            GajiBulanan = tambah / 100;

            Console.WriteLine("asyik naik gaji 10%");
        }
    }
}
