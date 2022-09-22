using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskFactory f = new TaskFactory();
            f.StartNew(() =>
            {
                bool stackOverflow = false;
                while (!stackOverflow)
                {
                    try
                    {
                        Console.Write("Thread: 1 ");
                        var temp = new InstanceCounter();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        stackOverflow = true;
                    }
                }
            });
            f.StartNew(() =>
            {
                bool stackOverflow = false;
                while (!stackOverflow)
                {
                    try
                    {
                        Console.Write("Thread: 2 ");
                        var temp = new InstanceCounter();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        stackOverflow = true;
                    }
                }
            });

            Console.ReadLine();
        }
    }
}
