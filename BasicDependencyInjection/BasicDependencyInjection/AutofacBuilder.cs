using Autofac;
using ConsoleApp3.Shapes;
using ConsoleApp3.Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AutofacBuilder
    {
        private static IContainer container { get; set; }
        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Square>().As<IShape>();
            container = builder.Build();
            return container;
        }
    }
}
