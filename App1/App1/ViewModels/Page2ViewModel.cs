using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using App1.Services;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class Page2ViewModel : BaseViewModel
    {
        private readonly IPageService _pageService;
        private readonly string _test;

        public ICommand CommandExecute { get; set; }
        public ICommand CommandNextPage { get; set; }
        public ICommand CommandNavigateBack { get; set; }

        public Page2ViewModel(IPageService pageService, string test)
        {
            _pageService = pageService;
            _test = test;

            CommandExecute = new Command(async () => await _pageService.DisplayAlert(_test, _test, _test));
            CommandNavigateBack = new Command(async () => await _pageService.NavgationPopAsync());
            CommandNextPage = new Command(async () => await _pageService.NavigationPushAsync(new Page3()));
        }
    }
}
