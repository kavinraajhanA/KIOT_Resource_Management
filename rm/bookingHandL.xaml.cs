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
	public partial class bookingHandL : ContentPage
	{
		public bookingHandL ()
		{
			InitializeComponent ();
		}

        private void LabBooking(object sender, EventArgs e)
        {
			Navigation.PushAsync(new dept());
        }

        private void HallBooking(object sender, EventArgs e)
        {
			Navigation.PushAsync(new HallsList());
        }

        private void HallBookingHLBack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserMain());
        }
    }
}