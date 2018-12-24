using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using App1.Interfaces;
using App1.Services;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class Page3ViewModel
    {
        private IPageService _pageService;
        private IStringProvider _stringProvider;

        public ICommand CommandExecute  { get; set; }
        public ICommand CommandNextPage { get; set; }
        public ICommand CommandNavigateBack { get; set; }

        public Page3ViewModel(IPageService pageService, IStringProvider stringProvider)
        {
            _pageService = pageService;
            _stringProvider = stringProvider;

            CommandExecute = new Command( async () => await _pageService.DisplayAlert(_stringProvider.GetString(),_stringProvider.GetString(), stringProvider.GetString()));
            CommandNavigateBack = new Command(async () => await _pageService.NavgationPopAsync());
        }
    }
}
