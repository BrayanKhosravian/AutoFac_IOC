using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Services
{
    interface IPageService
    {
        Task DisplayAlert(string title, string content, string ok);
        Task NavigationPushAsync(Page nextPage);
        Task NavgationPopAsync();
    }


}
