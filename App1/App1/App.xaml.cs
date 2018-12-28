using System;
using System.Collections.Generic;
using App1.Interfaces;
using App1.Services;
using App1.ViewModels;
using App1.Views;
using Autofac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// using Microsoft.Practices.ServiceLocation;
using App1.Autofac;
using App1.AutofacModules;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        private readonly IStringProvider _stringProvider;

        public App(IStringProvider stringProvider)
        {
            InitializeComponent();

            _stringProvider = stringProvider;

            var builder = new ContainerBuilder();

            // register viewmodels and services with modules (located in App1.Autofac)
            builder.RegisterModule<ViewModelModule>();
            builder.RegisterModule<ServiceModule>();

            // register instance from platform specifics
            builder.RegisterInstance<IStringProvider>(stringProvider).SingleInstance();

            var container = builder.Build();
            ViewModelLocator2.SetContainerProvider(container);

            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
