using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject_Try
{
    class ThingDoer : IThingDoer
    {
        public void Go()
        {
            Console.WriteLine("Doing things");
        }
    }
}
