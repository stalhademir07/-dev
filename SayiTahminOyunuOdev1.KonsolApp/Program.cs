using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunuOdev1.KonsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int seviye, rastgele, tahmin, seviye1 = 5, seviye2 = 4, seviye3 = 3;
            Random rnd = new Random();
            Console.WriteLine("Zorluk Seviyesini Seç.\n Kolay (0-20)-5 hak icin ‘1’ \n Orta (0-40) -4 hak icin ‘2’ \nZor (0-100) -3 hak icin ‘3’ giriniz");

            try
            {
                seviye = Int32.Parse(Console.ReadLine());
                switch (seviye)
                {
                    case 1:
                        rastgele = rnd.Next(1, 20);
                        for (int i = 0; i < 5; i++)
                        {

                            Console.WriteLine("Tahmin Et!");
                            tahmin = Int32.Parse(Console.ReadLine());
                            seviye1--;

                            if (seviye1 == 0)
                            {

                                Console.WriteLine("Birdahaki sefere :D");

                                break;
                            }
                            if (tahmin == rastgele)
                            {
                                Console.WriteLine("Tebrikler :D");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(seviye1 + " hakkın kaldı");


                            }

                        }

                        break;

                    case 2:
                        rastgele = rnd.Next(1, 40);
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Tahmin Et!");
                            tahmin = Int32.Parse(Console.ReadLine());
                            seviye2--;
                            if (seviye2 == 0)
                            {
                                Console.WriteLine("Birdahaki Sefere :D");
                                break;
                            }
                            if (tahmin == rastgele)
                            {
                                Console.WriteLine("Tebrikler :D");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(seviye2 + " hakkınız kaldı");
                            }

                        }

                        break;

                    case 3:
                        rastgele = rnd.Next(1, 100);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Tahmin Et");
                            tahmin = Int32.Parse(Console.ReadLine());
                            seviye3--;
                            if (seviye3 == 0)
                            {
                                Console.WriteLine("Birdahaki Sefere :D");
                                break;
                            }
                            if (tahmin == rastgele)
                            {
                                Console.WriteLine("Tebrikler :D");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(seviye3 + " hakkınız kaldı");
                            }

                        }

                        break;

                    default:
                        Console.WriteLine("Maalesef Tekrar Deneyiniz...");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Sayısal Değer Gir!");

            }
            Console.ReadKey();
        }
    }
}
