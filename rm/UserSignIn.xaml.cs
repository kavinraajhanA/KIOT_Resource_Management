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
	public partial class UserSignIn : ContentPage
	{
		public UserSignIn ()
		{
			InitializeComponent ();
		}

        private void signin(object sender, EventArgs e)
        {
			Navigation.PushAsync(new UserMain());
        }

        private void SignInBack(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}