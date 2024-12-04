using System;

namespace edinoe_chislo
{
    class Program
    {
        static void Main()
        {
            // Ввод массива пользователем
            Console.WriteLine("Введите элементы через пробел:");
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(input, int.Parse);

            // Переменные для хранения уникальных чисел
            int first = 0, second = 0;
            int uniqueCount = 0;

            // Поиск чисел, которые встречаются только один раз
            for (int i = 0; i < nums.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] == nums[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    if (uniqueCount == 0)
                    {
                        first = nums[i];
                        uniqueCount++;
                    }
                    else if (uniqueCount == 1)
                    {
                        second = nums[i];
                        uniqueCount++;
                    }
                }
            }

            // Вывод результата
            if (uniqueCount >= 2)
            {
                Console.WriteLine("Два элемента, которые появляются только один раз: " + first + ", " + second);
            }
            else
            {
                Console.WriteLine("Недостаточно элементов");
            }
        }
    }
}
