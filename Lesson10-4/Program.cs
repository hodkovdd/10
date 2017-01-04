using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_4
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("class A");
        }
    }

    class B : A
    {
        public virtual void Show()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : B
    {
        public virtual void Show()
        {
            Console.WriteLine("Class C");
        }
    }


    class X : C
    {
        public override void Show()
        {
            Console.WriteLine("class X");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A link = new X();
            link.Show();
            Console.ReadLine();
        }
    }
}
