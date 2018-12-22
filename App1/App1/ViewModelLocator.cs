using System;
using System.Collections.Generic;
using System.Text;
using App1.Services;
using App1.ViewModels;
using App1.Views;
using Autofac;

namespace App1
{
    static class ViewModelLocator
    {
        private static IContainer _container;

        static ViewModelLocator()
        {
            var builder = new ContainerBuilder();

            // ViewModels
            builder.RegisterType<Page1ViewModel>();
            builder.RegisterType<Page2ViewModel>();

            // services
            builder.RegisterType<PageService>().As<IPageService>().SingleInstance();

            _container = builder.Build();
        }

        public static T ResolveWithParameter<T>(NamedParameter parameter) where T : class
        {
            return _container.Resolve<T>(parameter);
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
