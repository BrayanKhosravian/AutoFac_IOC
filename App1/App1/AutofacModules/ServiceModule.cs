using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using App1.Services;

namespace App1.AutofacModules
{
    class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PageService>().As<IPageService>().SingleInstance();
        }
    }
}
