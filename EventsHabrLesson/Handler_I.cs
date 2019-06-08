using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHabrLesson
{
    class Handler_I
    {
        public void Message(int numb)
        {
            Console.WriteLine("Пора действовать, ведь уже {0}!", numb);
        }
    }
}
