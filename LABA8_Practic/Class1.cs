using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA8_Practic
{
    class Class1
    {
 
        static void Main(string[] args)
        {
            // Получение текущего времени
            DateTime currentTime = DateTime.Now;

            // Установка времени для проверки скидки (с 8:00 до 12:00)
            DateTime discountStartTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
            DateTime discountEndTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 12, 0, 0);

            // Пример ряда продуктов и их цен
            string[] products = { "Семга", "Красная игра", "Креветки" };
            double[] prices = { 2.0, 1.5, 3.0 };

            double total = 0.0;

            Console.WriteLine("Продукты в корзине:");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]} - {prices[i]}");

                if (currentTime >= discountStartTime && currentTime <= discountEndTime)
                {
                    // Применяем скидку 5% в указанное время
                    total += prices[i] * 0.95;
                }
                else
                {
                    total += prices[i];
                }
            }

            Console.WriteLine($"Итого: {total}");
        }
    }
}
