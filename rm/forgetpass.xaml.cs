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
	public partial class forgetpass : ContentPage
	{
		public forgetpass ()
		{
			InitializeComponent ();
		}

        private void backlog(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void tologin(object sender, EventArgs e)
        {
			Navigation.PushAsync(new login());
        }
    }
}