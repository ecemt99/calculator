// See https://aka.ms/new-console-template for more information
using System;

namespace Hesapmakinesi 
{
    class Program
    {
        private static double result;

        static void Main (string [] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("İlk sayıyı girin:");
            while(!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin:");
            }
            Console.WriteLine("İkinci sayıyı girin:");
            while(!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin:");
            }

            Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, / , kare , karekök , ln , log):");
            while(!char.TryParse(Console.ReadLine(), out operation)|| (operation != '+' && operation != '-' && operation != '*' && operation != '/' && operation != 'k' && operation != 'K' && operation != 'r' && operation != 'R' && operation != 'g' && operation != 'G'))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir işlem seçin (+, -, *, /):");
            }

            switch (operation)
            {
                case '+':
                   result = num1 + num2;
                   break;
                case '-':
                   result = num1 - num2;
                   break;
                case '*':
                   result = num1 * num2;
                   break;
                case '/':
                   if (num2 == 0)
                   {
                    Console.WriteLine("Sıfıra bölme hatası!");
                    return;
                   }
                   result = num1 / num2;
                   break;
                case 'k':
                case 'K':
                   result = num1 * num2; // Karesini alma
                   break;
                case 'r':
                case 'R':
                    if (num1 < 0 )
                    {
                        Console.WriteLine("Negatif sayının karakökü yok!");
                        return;
                    }
                    result = Math.Sqrt(num1); // Karakök alma
                    break;
                case 'l':
                case 'L':
                    if (num1 <= 0)
                    {
                        Console.WriteLine("Doğal logaritması alınacak sayı pozitif olmalıdır!");
                        return;
                    }
                    result = Math.Log(num1); // Doğal logaritma alınacak
                    break;
                case 'g':
                case 'G':
                    if (num1 <= 0 || num2 <= 1)
                    {
                         Console.WriteLine("Logaritma tabanı pozitif olmalı ve logaritmanın alınacak sayı 1'den büyük olmalıdır!");
                        return;  
                    }
                    result = Math.Log(num1, num2); // Belirli tabanlı logaritma
                    break;
                default:
                   Console.WriteLine("Geçersiz işlem!");
                   return;
            }

                Console.WriteLine("Sonuç:" + result);

        }  
    }
}
