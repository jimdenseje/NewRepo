using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne_2___Polymorfi___override
{
    internal class humans
    {
        public virtual void eating() {
            Console.WriteLine("Spiser som et menneske");
        }
    }
    internal class woman : humans
    {

    }
    internal class man : humans
    {
        public override void eating()
        {
            Console.WriteLine("Spiser som et mandfolk");
        }
    }

    internal static class myoverride
    {
        public static void toTry()
        {
            var human = new humans();
            var woman = new woman();
            var man = new man();

            human.eating();
            woman.eating();
            man.eating();
            Console.WriteLine();
        }
    }

}
