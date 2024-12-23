using System;

class Program
{
    static void Main()
    {
        int[] sequence = new int[1000];
        Random rand = new Random();

        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = rand.Next(10001); // заполнение последовательности случайными значениями от 0 до 10000
        }

        int maxR = -1;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            for (int j = i + 1; j < sequence.Length; j++)
            {
                int product = sequence[i] * sequence[j];

                if (product % 14 == 0 && product > maxR)
                {
                    maxR = product;
                }
            }
        }

        if (maxR == -1)
        {
            Console.WriteLine("Числа, удовлетворяющие условиям, не найдено.");
        }
        else
        {
            Console.WriteLine("Максимальное число R, удовлетворяющее условиям: " + maxR);
        }
    }
}
        