using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class dept : ContentPage
	{
		public dept ()
		{
			InitializeComponent ();
		}

        private void DeptBack(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void viewlabs(object sender, EventArgs e)
        {
			Navigation.PushAsync(new MainPage());
        }
    }
}