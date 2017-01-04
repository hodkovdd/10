using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10_3
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
        public override void Show()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : B
    {
        public new void Show()
        {
            Console.WriteLine("class C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A link = new C();
            link.Show();
            Console.ReadLine();
        }
    }
}
