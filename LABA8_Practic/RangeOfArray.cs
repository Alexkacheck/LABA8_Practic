using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA8_Practic
{
    public class RangeOfArray
    {
        private int lowerBound; // Нижний индекс
        private int upperBound; // Верхний индекс
        private int[] array;    // Массив данных

        public RangeOfArray(int lower, int upper)
        {
            lowerBound = lower;  // Инициализируем нижний индекс пользовательским значением.
            upperBound = upper;  // Инициализируем верхний индекс пользовательским значением.
            array = new int[upper - lower + 1];  // Создаем массив, размер которого зависит от пользовательских индексов.
        }

        public int this[int index]
        {
            get
            {
                if (IsIndexValid(index)) // Проверяем, допустим ли данный индекс.
                {
                    return array[index - lowerBound];  // Возвращаем элемент массива с учетом смещения на нижний индекс.
                }
                else
                {
                    Console.WriteLine("Недопустимый индекс.");  // Если индекс недопустим, выводим сообщение и возвращаем 0.
                    return 0;
                }
            }
            set
            {
                if (IsIndexValid(index))  // Проверяем, допустим ли данный индекс.
                {
                    array[index - lowerBound] = value;  // Устанавливаем значение элемента массива с учетом смещения на нижний индекс.
                }
                else
                {
                    Console.WriteLine("Недопустимый индекс.");  // Если индекс недопустим, выводим сообщение.
                }
            }
        }

        private bool IsIndexValid(int index)
        {
            return index >= lowerBound && index <= upperBound;  // Проверяем, находится ли индекс в допустимом диапазоне.
        }
    }
}