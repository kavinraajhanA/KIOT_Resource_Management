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
	public partial class UserFP : ContentPage
	{
		public UserFP ()
		{
			InitializeComponent ();
		}

        private void FPback(object sender, EventArgs e)
        {
            Navigation.PopAsync();  
        }

        private void FPSubmoit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new login());
        }
    }
}