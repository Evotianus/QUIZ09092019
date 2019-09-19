using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void luas_persegi()
        {
            Console.WriteLine("Menghitung luas persegi");
            Console.WriteLine("-----------------------");

            int sisi;
            Console.Write("Masukkan nilai sisi ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;

            Console.WriteLine("Luas persegi adalah "+luas);
        }

        public void luas_segitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("------------------------");

            int alas,tinggi,a,b,z,luassegitiga;
            Console.Write("Masukkan nilai alas ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            a = 1;
            b = 2;

            z = a * alas * tinggi;
            luassegitiga = z / b;

            Console.WriteLine("Luas segitiga adalah "+luassegitiga);
        }
        public void luas_lingkaran()
        {
            Console.WriteLine("Menghitung luas lingkaran");
            Console.WriteLine("-------------------------");
            int ll,p,q,s,ruas;

            p = 22;
            q = 7;

            Console.Write("Masukkan Nilai ruas ");
            ruas = Convert.ToInt32(Console.ReadLine());

            s = p * ruas * ruas;
            ll = s / q;

            Console.WriteLine("Luas lingkaran adalah "+ll);   
            }
        }
    }   