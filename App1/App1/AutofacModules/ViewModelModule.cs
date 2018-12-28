using System;
using System.Collections.Generic;
using System.Text;
using App1.ViewModels;
using Autofac;

namespace App1.Autofac
{
    class ViewModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Page1ViewModel>();
            builder.RegisterType<Page2ViewModel>();
            builder.RegisterType<Page3ViewModel>();
        }
    }
}
