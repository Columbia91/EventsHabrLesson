using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHabrLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter counter = new ClassCounter();
            Handler_I handler1 = new Handler_I();
            Handler_II handler2 = new Handler_II();

            //counter.onCount += handler1.Message;
            //counter.onCount += handler2.Message;

            counter.Count();

            Console.ReadLine();
        }
    }
}
