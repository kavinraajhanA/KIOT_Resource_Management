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
	public partial class adminpro : ContentPage
	{
		public adminpro ()
		{
			InitializeComponent ();
		}

    
        

        private void Faculty_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Faculty());
        }

        private void Addlab_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addlab());
        }

        private void Password_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new chanpass());
        }

        private void LogOut(object sender, EventArgs e)
        {
            Navigation.PushAsync(new login());
        }

        private void backadmin(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}