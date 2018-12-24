using System;
using App1.Interfaces;
using App1.Services;
using App1.ViewModels;
using App1.Views;
using Autofac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        private readonly IStringProvider _stringProvider;

        private static IContainer _container;

        public App(IStringProvider stringProvider)
        {
            InitializeComponent();

            _stringProvider = stringProvider;

            ViewModelLocator.RegisterViewModels();
            ViewModelLocator.RegisterServices();
            ViewModelLocator.RegisterInstance<IStringProvider>(stringProvider);
            ViewModelLocator.Build();

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
