using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;

namespace Ninject_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            //var kernal =new StandardKernel();
            //kernal.Load(Assembly.GetExecutingAssembly());
            //var myModule = kernal.Get<TopModule>();
            var myModule = ModuleLoader.ThisInstance.Get<TopModule>();
            myModule.Start();

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }
    }
}
