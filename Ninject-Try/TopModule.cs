using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject_Try
{
    class TopModule
    {
        private IThingDoer _doer;
        public TopModule(IThingDoer Doer)
        {
            _doer = Doer;
        }

        public void Start() { _doer.Go(); }
    }
}
