using System;
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process[] processes = Process.GetProcesses();

        Console.WriteLine("ID\tName");

        foreach (Process process in processes)
        {
            Console.WriteLine($"{process.Id}\t{process.ProcessName}");
        }
    }