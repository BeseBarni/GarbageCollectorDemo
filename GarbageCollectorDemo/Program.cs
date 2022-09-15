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
                List<InstanceCounter> list = new List<InstanceCounter>();
                bool stackOverflow = false;
                while (!stackOverflow)
                {
                    try
                    {
                        Console.Write("Thread: 1 ");
                        list.Add(new InstanceCounter());
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
                List<InstanceCounter> list = new List<InstanceCounter>();
                bool stackOverflow = false;
                while (!stackOverflow)
                {
                    try
                    {
                        Console.Write("Thread: 2 ");
                        list.Add(new InstanceCounter());
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
