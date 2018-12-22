using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Services
{
    class PageService : IPageService
    {
        public async Task DisplayAlert(string title, string content, string ok)
        {
           await Application.Current.MainPage.DisplayAlert(title, content, ok);
        }

        public async Task NavigationPushAsync(Page nextPage)
        {
            await Application.Current.MainPage.Navigation.PushAsync(nextPage);
        }

        public async Task NavgationPopAsync()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
