using System;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 6, 12, 24, 3, 8, 4};
            kabarcikSirala(dizi);
            diziYazdir(dizi);
        }
        public static void kabarcikSirala(int[]siralanacakDizi) {
 
            int i = 1,  j, deger;
            int diziAdet = siralanacakDizi.Length;
            while (i < diziAdet)
            {
                j = diziAdet - 1;
                while (j >= 1)
                {
                    if (siralanacakDizi[j - 1] > siralanacakDizi[j])
                    {
                        deger = siralanacakDizi[j];
                        siralanacakDizi[j] = siralanacakDizi[j - 1];
                        siralanacakDizi[j - 1] = deger;
                    }
                    j--;
                }
                i++;
            }
        }
 
        public static void diziYazdir(int[] dizi) {
 
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadKey();
    }
}
}
