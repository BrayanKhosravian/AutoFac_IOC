using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Services;
using App1.ViewModels;
using Autofac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
	    private string _parameter;
		public Page2 (string parameter)
		{
			InitializeComponent ();
		    _parameter = parameter;

		    BindingContext = ViewModelLocator2.ResolveWithParameter<Page2ViewModel>(new NamedParameter("test", parameter));
		}
	}
}