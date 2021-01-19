using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //string a1 = "Selam";
            ////int a2 = a1;//tür uyuşmazlığı
            //object obj = a1;//BOXİNG

            ////double sonuc = obj + obj;
            //Console.WriteLine(obj);

            //Insan Ins = new Insan();
            //Ins.Isim = "Alp";
            //Ins.Soyad = "Sarıkışla";

            //obj = Ins;//BOXİNG

            //Insan ins2 = (Insan)obj;//Unboxing
            //Console.WriteLine(ins2.Isim);

            //Console.WriteLine(((Insan)obj).Isim);
            #endregion

            #region dizi

            //object[] dizi = new object[5];
            //dizi[0] = 12;
            //dizi[1] = 45.8;
            //dizi[2] = "selam";
            //dizi[3] = 'A';
            //dizi[4] = 123.7m;

            //int[] sayilar = new int[5];
            //sayilar[0] = 3;
            //sayilar[1] = 13;
            //sayilar[2] = 23;
            //sayilar[3] = 33;
            //sayilar[4] = 43;

            //object obj = sayilar; //boxing işlemi

            //int[] sayilar2 = (int[])obj; //unboxing işlemi
            //Console.WriteLine(sayilar2[3]);
            

            #endregion


        }
    }
    class Insan
    {
        public string Isim { get; set; }
        public string Soyad { get; set; }
    }
        
}
