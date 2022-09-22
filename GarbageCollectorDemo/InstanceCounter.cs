using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    public class InstanceCounter
    {
        static int objectCount = 0;

        public InstanceCounter()
        {
            objectCount++;
            Console.WriteLine("Object created, Count: {0}",objectCount);
        }

        ~InstanceCounter()
        {
            objectCount--;
            ConsoleHelper.WriteErrorLine("Object destroyed, Count: " + objectCount);
        }
    }
}
