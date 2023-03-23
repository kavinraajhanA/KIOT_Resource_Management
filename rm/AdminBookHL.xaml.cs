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
	public partial class AdminBookHL : ContentPage
	{
		public AdminBookHL ()
		{
			InitializeComponent ();
		}

        private void HallBookingHLBack(object sender, EventArgs e)
        {

        }

        private void adminHLback(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void HallBooking(object sender, EventArgs e)
        {
            Navigation.PushAsync(new hallbookingdata());
        }

        private void LabBooking(object sender, EventArgs e)
        {
            Navigation.PushAsync(new labbookingdata());
        }
    }
}