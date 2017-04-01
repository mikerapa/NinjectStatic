using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;

namespace Ninject_Try
{
    public class ModuleLoader : Ninject.Modules.NinjectModule
    {
        private static StandardKernel _kernal;
        
        public static StandardKernel ThisInstance { get { return (_kernal); } }
        static ModuleLoader()
        {
            _kernal = new StandardKernel();
            _kernal.Load(Assembly.GetExecutingAssembly());
        }


        // register each type
        public override void Load()
        {
            Bind<IThingDoer>().To<ThingDoer>();
        }
    }
}
