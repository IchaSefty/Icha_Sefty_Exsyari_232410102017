// See https://aka.ms/new-console-template for more information
using Tugas_PBO1_1;

//Console.WriteLine("Hello, World!");

internal class Program
{
    static void Main(string[] args)
    {
        Mobilsedan nissan = new Mobilsedan("Nissan Teana", "Hitam", 2014, 5);
        Console.WriteLine($" Nama Mobil Sedan   : " + nissan.nama);
        Console.WriteLine($" Warna              : " + nissan.warna);
        Console.WriteLine($" Tahun Keluaran     : " + nissan.tahunkeluaran);
        Console.WriteLine($" Kapasitas Penumpang: " + nissan.kapasitas);

        Mobilsedan toyota = new Mobilsedan("Toyota Carolla Altis", "Red Mica Metallic", 2001, 5);
        Console.WriteLine($" Nama Mobil Sedan   : " + toyota.nama);
        Console.WriteLine($" Warna              : " + toyota.warna);
        Console.WriteLine($" Tahun Keluaran     : " + toyota.tahunkeluaran);
        Console.WriteLine($" Kapasitas Penumpang: " + toyota.kapasitas);

        Ikan nila = new Ikan("Nila", "Ikan Air Tawar", "Merah", 50);
        Console.WriteLine($" Nama Ikan: " + nila.nama);
        Console.WriteLine($" Jenis: " + nila.jenis);
        Console.WriteLine($" Warna: " + nila.warna);
        Console.WriteLine($" Berat: " + nila.berat + "gram");

        Ikan kakap = new Ikan("Kakap", "Ikan Air Laut", "Abu-abu", 700);
        Console.WriteLine($" Nama Ikan: " + kakap.nama);
        Console.WriteLine($" Jenis: " + kakap.jenis);
        Console.WriteLine($" Warna: " + kakap.warna);
        Console.WriteLine($" Berat: " + kakap.berat + "gram");

        Burung murai = new Burung("Murai Batu", "Hitam dan Jingga", "Sumatera");
        Console.WriteLine($" Nama Burung: " + murai.nama);
        Console.WriteLine($" Warna: " + murai.warna);
        Console.WriteLine($" Wilayah Persebaran: " + murai.wilayah);

        Burung kolibri = new Burung("Kolibri", "Hijau dan Coklat", "Jawa");
        Console.WriteLine($" Nama Burung: " + kolibri.nama);
        Console.WriteLine($" Warna: " + kolibri.warna);
        Console.WriteLine($" Wilayah Persebaran: " + kolibri.wilayah);

        Komputer asus = new Komputer("ASUS V22FAK AIO", "Silver", 2022, 256);
        Console.WriteLine($" Merek Komputer: " + asus.merek);
        Console.WriteLine($" Warna: " + asus.warna);
        Console.WriteLine($" Tahun Keluaran: " + asus.tahunkeluaran);
        Console.WriteLine($" Penyimpanan: " + asus.penyimpanan + "GB");

        Komputer dell = new Komputer("DELL VOSTRO 3681", "Hitam", 2021, 1);
        Console.WriteLine($" Merek Komputer: " + dell.merek);
        Console.WriteLine($" Warna: " + dell.warna);
        Console.WriteLine($" Tahun Keluaran: " + dell.tahunkeluaran);
        Console.WriteLine($" Penyimpanan: " + dell.penyimpanan + "TB");

    }

}