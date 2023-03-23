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
	public partial class bookinglab : ContentPage
	{
		public bookinglab ()
		{
			InitializeComponent ();
		}

        private void labCancel(object sender, EventArgs e)
        {
			Navigation.PushAsync(new bookingHandL());
        }

        private void LabBack(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}