using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO1_1
{
    internal class Komputer
    {
        public string merek;
        public string warna;
        public int tahunkeluaran;
        public int penyimpanan;

        public Komputer(string merek, string warna, int tahunkeluaran, int penyimpanan)
        {
            this.merek = merek;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;
            this.penyimpanan = penyimpanan;

        }
    }
}