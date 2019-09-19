using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void volume_balok()
        {
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-----------------------");

            int panjang,lebar,tinggi,volume;

            Console.Write("Masukkan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume balok adalah "+volume);
        }

        public void volume_kubus()
        {
            Console.WriteLine("Menghitung volume kubus");
            Console.WriteLine("-----------------------");

            int sisi,vk;

            Console.WriteLine("Masukkan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            vk = sisi * sisi * sisi;

            Console.WriteLine("Volume kubus adalah "+vk);

        }
    }
}