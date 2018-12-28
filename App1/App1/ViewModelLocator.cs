using System;
using System.Collections.Generic;
using System.Text;
using App1.Interfaces;
using App1.Services;
using App1.ViewModels;
using App1.Views;
using Autofac;
using Autofac.Core;

namespace App1
{
    [Obsolete("class is obsolete, please use ViewModelLocator2 instead")]
    static class ViewModelLocator
    {
        private static IContainer _container;
        private static ContainerBuilder _builder = new ContainerBuilder();

        static ViewModelLocator()
        {

        }

        public static T ResolveWithParameters<T>(params Parameter[] parameters) where T : class
        {
            if(parameters.Length == 0) throw new ArgumentNullException();
            if(parameters == null) throw new ArgumentNullException();

            if (parameters.Length == 1) return _container.Resolve<T>(parameters[0]);
            else
            {
                return _container.Resolve<T>(parameters);   
            }
        }

        public static T ResolveWithParameter<T>(NamedParameter parameter) where T : class
        {
            return _container.Resolve<T>(parameter);
        }

        public static void RegisterInstance<TInterface>(TInterface stringProvider) where TInterface : class
        {
            _builder.RegisterInstance<TInterface>(stringProvider).SingleInstance();
 
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public static void Build()
        {
            _container = _builder.Build();
        }

        public static void RegisterViewModels()
        {
            _builder.RegisterType<Page1ViewModel>();
            _builder.RegisterType<Page2ViewModel>();
            _builder.RegisterType<Page3ViewModel>();
        }

        public static void RegisterServices()
        {
            _builder.RegisterType<PageService>().As<IPageService>().SingleInstance();
        }

    }
}
