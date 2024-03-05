using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO1_1
{
    internal class Ikan
    {
        public string nama;
        public string jenis;
        public string warna;
        public int berat;

        public Ikan(string nama, string jenis, string warna, int berat)
        {
            this.nama = nama;
            this.jenis = jenis;
            this.warna = warna;
            this.berat = berat;
        }
    }
}
