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
	public partial class seminarhall : ContentPage
	{
		public seminarhall ()
		{
			InitializeComponent ();
		}

        private void hallbook(object sender, EventArgs e)
        {
			Navigation.PushAsync(new hallbook());
        }

        private void SeminarHallBack(object sender, EventArgs e)
        {
			Navigation.PopAsync();	
        }
    }
}