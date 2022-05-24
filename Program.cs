using System;
using System.Timers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




namespace Gas_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать на нашу заправку ! =)");
            Console.WriteLine("Какое топливо желаете?");
            string benz92 = "Бензин-92";
            string benz95 = "Бензин-95";
            string gas = "Газ";
            string disel = "Дизель";
            Console.WriteLine($"1. {benz92} - 50 grn. \n2. {benz95} - 65 grn. \n3. {gas} - 40 grn. \n4. {disel} - 80 grn.");
            Console.WriteLine("\n--------------------");
            #region Zakaz
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Сколько {benz92} вы желаете?");
                Console.WriteLine("--------------------");

            }
            else if (choose == 2)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Сколько {benz95} вы желаете?");
                Console.WriteLine("--------------------");

            }
            else if (choose == 3)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Сколько {gas}а вы желаете?");
                Console.WriteLine("--------------------");
            }
            else if (choose == 4)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Сколько Дизеля вы желаете?");
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Неверный выбор");
                Console.WriteLine("--------------------");
            }
            int choosenPatrol = choose;
            int amountOfPatrol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
            #endregion Zakaz
            #region Proverka kakoy benz
            if (choosenPatrol == 1)
            {


                for (int i = 0; i <= amountOfPatrol; i++)
                {
                    Thread.Sleep(200);
                    Console.Write($"\rЗаправляем {benz92} " + i + "l");

                }
                Console.WriteLine("\n--------------------");
                Console.WriteLine($"Спасибо за ожидание, вы заправились на {amountOfPatrol} литров. ");
                Console.WriteLine("--------------------");
                Console.WriteLine($"S vas {amountOfPatrol * 50} grn. Оплата картой или наличными?");
                Console.WriteLine("1. Карта \n2. Наличные");
                Console.WriteLine("--------------------");
                int oplata = Convert.ToInt32(Console.ReadLine());

                if (oplata == 1 || oplata == 2)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Оплата прошла успешно, спасибо за выбор нашей заправки!");
                    Console.WriteLine("Ждем Вас еще! До свидания!");
                }

                Console.ReadKey();
            }
            if (choosenPatrol == 2)
            {


                for (int i = 0; i <= amountOfPatrol; i++)
                {
                    Thread.Sleep(200);
                    Console.Write($"\rЗаправляем {benz95} " + i + "l");

                }
                Console.WriteLine("\n--------------------");
                Console.WriteLine($"Спасибо за ожидание, вы заправились на {amountOfPatrol} литров. ");
                Console.WriteLine("--------------------");
                Console.WriteLine($"С Вас {amountOfPatrol * 65} grn. Будете платить картой или наличными?");
                Console.WriteLine("1. Карта \n2. Наличные");
                Console.WriteLine("--------------------");
                int oplata = Convert.ToInt32(Console.ReadLine());

                if (oplata == 1 || oplata == 2)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Оплата прошла успешно!");
                    Console.WriteLine("Ждем вас еще, до свидания!");
                }

                Console.ReadKey();
            }
            if (choosenPatrol == 3)
            {


                for (int i = 0; i <= amountOfPatrol; i++)
                {
                    Thread.Sleep(200);
                    Console.Write($"\rЗаправляем {gas} " + i + "l");

                }
                Console.WriteLine("\n--------------------");
                Console.WriteLine($"Спасибо за ожидание, вы заправились на {amountOfPatrol} литров. ");
                Console.WriteLine("--------------------");
                Console.WriteLine($"С Вас {amountOfPatrol * 40} grn. Будете платить картой или наличными?");
                Console.WriteLine("1. Karta \n2. Nalichnue");
                Console.WriteLine("--------------------");
                int oplata = Convert.ToInt32(Console.ReadLine());

                if (oplata == 1 || oplata == 2)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Оплата прошла успешно, spasibo chto bubrali nashu zapravku!");
                    Console.WriteLine("Zdem vas Eshe! Do svidaniya!");
                }

                Console.ReadKey();
            }
            if (choosenPatrol == 4)
            {


                for (int i = 0; i <= amountOfPatrol; i++)
                {
                    Thread.Sleep(200);
                    Console.Write($"\rZapravlyaem {disel} " + i + "l");

                }
                Console.WriteLine("\n--------------------");
                Console.WriteLine($"Spasibo za ogidanie, vi zapravilis na {amountOfPatrol} litrov. ");
                Console.WriteLine("--------------------");
                Console.WriteLine($"S vas {amountOfPatrol * 80} grn. Budete platit kartoy ili nalishnumi?");
                Console.WriteLine("1. Karta \n2. Nalichnue");
                Console.WriteLine("--------------------");
                int oplata = Convert.ToInt32(Console.ReadLine());

                if (oplata == 1 || oplata == 2)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Oplata proshla uspeshno, spasibo chto bubrali nashu zapravku!");
                    Console.WriteLine("Zdem vas Eshe! Do svidaniya!");
                }

                Console.ReadKey();
            }
            #endregion


            Console.ReadKey();
        }
    }
}