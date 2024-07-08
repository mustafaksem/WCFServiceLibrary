using System;
using System.ServiceModel;

namespace _08._07._24.WCFLibrary
{
    public class Service1 : IService1
    {
        public int HesapTopla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int HesapCikar(int sayi1, int sayi2)
        {
            if (sayi1 < sayi2)
                return sayi2 - sayi1;

            return sayi1 - sayi2;
        }

        public int HesapCarp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public double HesapBol(int sayi1, int sayi2)
        {
            if (sayi2 == 0)
            {
                throw new DivideByZeroException("Bölen sıfır olamaz.");
            }
            return (double)sayi1 / sayi2;
        }
    }
}
