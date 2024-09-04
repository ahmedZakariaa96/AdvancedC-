using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_.MultiThrading
{
    public static class MultiThrading
    {
        private static object _lock=new ();
        public static async Task Process1(object? state )
        {
            Console.WriteLine("Process1 thread is "+ Environment.CurrentManagedThreadId);

            await Task.Delay(1);
            Console.WriteLine("Process1.1 thread is "+ Environment.CurrentManagedThreadId);

            for (int i = 0; i < 100; i++)
            {
                lock(_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
              

            }
        }
        public static async Task Process2(object? state )
        {
            Console.WriteLine("Process2 thread is "+ Environment.CurrentManagedThreadId);

            await Task.Delay(2);
            Console.WriteLine("Process2.1 thread is "+ Environment.CurrentManagedThreadId);


            for (int j = 100;j < 200;j++)
            {
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(j);
                    Console.ForegroundColor = ConsoleColor.White;
                }
               

            }
        }
    }
}
