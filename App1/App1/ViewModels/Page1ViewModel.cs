using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using App1.Services;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class Page1ViewModel : BaseViewModel
    {
        private IPageService _pageService;

        public ICommand CommandExecute { get; set; }
        public ICommand CommandNextPage { get; set; }

        public Page1ViewModel(IPageService pageService)
        {
            _pageService = pageService;
            
            CommandExecute = new Command( async () => await _pageService.DisplayAlert("as","sadasd","sd"));
            CommandNextPage = new Command( async () => await _pageService.NavigationPushAsync(new Page2("I am a string")));
        }
    }
}
