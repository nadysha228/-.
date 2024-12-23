using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        // Создаем переменные 
        Thread chicken = new Thread(Chicken);
        Thread egg = new Thread(Egg);

        // Запускаем потоки
        chicken.Start();
        egg.Start();

        // Ждем завершения потоков
        chicken.Join();
        egg.Join();

        // Проверяем, какой поток завершился последним
        if (chicken.IsAlive)
        {
            Console.WriteLine("Яйцо");
        }
        else
        {
            Console.WriteLine("Курица");
        }
    }
    static void Chicken()
    {
        // Простой вывод слова "Курица"
        Console.WriteLine("Курица");
    }

    static void Egg()
    {
        // Простой вывод слова "Яйцо"
        Console.WriteLine("Яйцо");
    }
}