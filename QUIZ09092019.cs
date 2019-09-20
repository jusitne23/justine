using System;

namespace TUGASPD_BANGUNDATAR
{
    class BangunDatar
    {
     
        public void luas_persegi(int sisi)
        {
            Console.WriteLine("luas persegi adalah "+sisi * sisi);
        }

        public int luas_segitiga(int alas, int tinggi)
        {
            return  alas * tinggi / 2;
        }


          public void luas_lingkaran(int r)
        {
            Console.WriteLine("luas lingkaran adalah "+3.14 * r * r);
        }

     
    }
}