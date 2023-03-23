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
	public partial class profile : ContentPage
	{
		public profile ()
		{
			InitializeComponent ();
		}

        private void Name_Clicked(object sender, EventArgs e)
        {

        }

        private void Department_Clicked(object sender, EventArgs e)
        {

        }

        private void Email_Clicked(object sender, EventArgs e)
        {

        }

        private void number_Clicked(object sender, EventArgs e)
        {

        }

        private void Password(object sender, EventArgs e)
        {

        }

        private void LogOut(object sender, EventArgs e)
        {
            Navigation.PushAsync(new login());
        }

        private void proback(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}