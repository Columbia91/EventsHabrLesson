using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHabrLesson
{
    public delegate void MethodContainer(int numb);
    class ClassCounter
    {
        // чтобы не словить исключение при отсутствии у события методов добавляем delegate{}
        public event MethodContainer onCount = delegate { };
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    onCount(i);
                }
            }
        }
    }
}
