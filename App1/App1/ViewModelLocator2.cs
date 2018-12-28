using System;
using System.Collections.Generic;
using System.Text;
using App1.ViewModels;
using Autofac;
using Autofac.Core;
using Autofac.Core.Activators;

namespace App1
{

    public static class ViewModelLocator2
    {
        private static IContainer _container;

        public static void SetContainerProvider(IContainer container)
        {
            _container = container;
        }

        public static T ResolveWithParameters<T>(params Parameter[] parameters) where T : class
        {
            if (parameters.Length == 0) throw new ArgumentNullException();
            if (parameters == null) throw new ArgumentNullException();

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

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
