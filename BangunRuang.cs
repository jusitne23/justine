using System;

namespace TUGASPD_BANGUNDATAR
{
    class BangunRuang
    {
     

     public int volume_balok(int panjang, int tinggi, int lebar)
        {
            return  panjang * tinggi * lebar;
        }
        public void volume_kubus(int sisi)
        {
            Console.WriteLine("volume kubus adalah "+sisi * sisi * sisi);
        }

        
        }
    }