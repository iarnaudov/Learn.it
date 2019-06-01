using ConsoleApp3.Shapes;
using ConsoleApp3.Shapes.Interfaces;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NinjectBuilder : NinjectModule
    {
        StandardKernel kernel;
        public NinjectBuilder(StandardKernel kernel)
        {
            this.kernel = kernel;
        }
        public override void Load()
        {
            kernel.Bind<IShape>().To<Square>();
        }
    }
}
