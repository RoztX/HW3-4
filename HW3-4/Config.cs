using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace HW3_4
{
    public class Config
    {
        public IContainer RegistrarDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OutputList>().As<IOutput>();
            builder.RegisterType<SortList>().As<ISort>();
            builder.RegisterType<FilterList>().As<IFilter>();
            builder.RegisterType<Starter>();

            var cotainer = builder.Build();
            return cotainer;
        }
    }
}
