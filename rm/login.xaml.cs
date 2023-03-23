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
	public partial class login : ContentPage
	{
		public login ()
		{
			InitializeComponent ();
		}

        private void Login(object sender, EventArgs e)
        {
			Navigation.PushAsync(new UserMain());
        }

        private void forpw(object sender, EventArgs e)
        {
			Navigation.PushAsync(new forgetpass());
        }

        private void SignIn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserSignIn());
        }
    }
}