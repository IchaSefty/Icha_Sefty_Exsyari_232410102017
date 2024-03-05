using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO1_1
{
    internal class Mobilsedan
    {
        public string nama;
        public string warna;
        public int tahunkeluaran;
        public int kapasitas;

        public Mobilsedan(string nama, string warna, int tahunkeluaran, int kapasitas)
        {
            this.nama = nama;
            this.warna = warna;
            this.tahunkeluaran = tahunkeluaran;
            this.kapasitas = kapasitas;
        }
    }
}
