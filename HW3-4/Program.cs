using HW3_4;
using Autofac;

var config = new Config();
var container = config.RegistrarDependency();
var starter = container.Resolve<Starter>();
starter.Run();
