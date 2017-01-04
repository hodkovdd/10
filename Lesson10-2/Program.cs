using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_2
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : A
    {
        public new virtual void Show()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : B
    {
        public override void Show()
        {
            Console.WriteLine("Class C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            B link = new C();
            Console.WriteLine(link.GetType());
            link.Show();
            Console.ReadLine();
        }
    }
}
