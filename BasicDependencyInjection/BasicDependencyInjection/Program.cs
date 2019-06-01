using Autofac;
using ConsoleApp3.Shapes;
using ConsoleApp3.Shapes.Interfaces;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // AutoFac
            //IContainer container = new AutofacBuilder().Build();

            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var shape = scope.Resolve<IShape>();
            //    Run(shape);
            //}


            // Ninject
            StandardKernel kernel = new StandardKernel();
            new NinjectBuilder(kernel).Load();
            kernel.Load(Assembly.GetExecutingAssembly());
            IShape shape = kernel.Get<IShape>();
            Run(shape);
        }

        public static void Run(IShape shape)
        {
            shape.SayShape();
            Console.ReadLine();  
        }
    }
}
