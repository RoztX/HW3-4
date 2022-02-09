using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    public class Config
    {
        public IContainer RegistrarDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ListOfTransportOutput>().As<IListOfTransportOutput>();
            builder.RegisterType<ListOfTransportSort>().As<IListOfTransportSort>();
            builder.RegisterType<ListOfTransportFilter>().As<IListOfTransportFilter>();
            builder.RegisterType<Starter>();

            var cotainer = builder.Build();
            return cotainer;
        }
    }
}
