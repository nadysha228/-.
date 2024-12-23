using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process[] notepads = Process.GetProcessesByName("notepad");

        foreach (Process notepad in notepads)
        {
            notepad.Kill();
            Console.WriteLine("Notepad closed successfully");
        }
    }
}