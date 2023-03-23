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
	public partial class hallbook : ContentPage
	{
		public hallbook ()
		{
			InitializeComponent ();
		}

        private void CancelHall(object sender, EventArgs e)
        {
			Navigation.PushAsync(new bookingHandL());
        }

        private void BCBack(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}