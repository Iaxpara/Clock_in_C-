using System;
using System.Threading;

class Clock
{
    static void Main()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Thread.Sleep(1000);
        }
    }
}