using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionTwo
{
    public abstract class Karyawan
    {
        public abstract string Nama { get; set; }
        public abstract string Nik { get; set; }
        public abstract double Gaji();
    }
}