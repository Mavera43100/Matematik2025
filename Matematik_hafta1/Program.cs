using System;

namespace Matematik_hafta1
{
    internal class Program
    {
       // bütün kodlar bir class içerisinde yer alması gerekiyor.
        static void Main(string[] args)
        {
            // Main metodu, programın giriş noktasıdır.
            //her bir consol uygulaması "main bloğu ile başlar...
            // ve main bloğu ile biter.
            // Main bloğu içerisindeki kodlar sırasıyla çalıştırılır.

            //Console.WriteLine() metodu, ekrana yazı yazdırmak için kullanılır.
            //Console.WriteLine() metodu, yazdırdıktan sonra bir alt satıra geçer.
            //Console.Write() metodu, ekrana yazı yazdırmak için kullanılır.

            //Console sınıfı System uzayında yer alır.

            //Console.Write("Hello World!");
            //Console.WriteLine("Matematik bölümü, Merhaba");

            //Console.WriteLine(5 * 2);
            //Console.WriteLine("5 * 2");
            //Console.WriteLine("10 * 2 ={0}", (10 * 2));
            //readline metodu klavyeden enter tuşuna basılana kadar bekler.
            //projeyi derlemek için CTRL + SHIFT + B tuşları kullanılır.

            //ekrana bilgi yazdırma
            Console.WriteLine("Adınız Nedir");
            //klavyeden veri almak için kullanılır.
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız Nedir");
            string soyad = Console.ReadLine();
            //birden fazla metin(string)değişkenin birleştirilmesini sağladık
            Console.WriteLine("Girdiğiniz ad ve soyad :{0}",ad+" "+soyad);
            //Ekranı bekletmek için (enter tuşuna basılana kadar)
            Console.ReadLine();



        }
    }
}
