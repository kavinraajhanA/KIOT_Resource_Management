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
	public partial class UserCP : ContentPage
	{
		public UserCP ()
		{
			InitializeComponent ();
		}

        private void UserPassSub(object sender, EventArgs e)
        {
			Navigation.PushAsync(new profile());
        }

        private void CPBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();  
        }
    }
}