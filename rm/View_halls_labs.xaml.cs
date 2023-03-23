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
	public partial class View_halls_labs : ContentPage
	{
		public View_halls_labs ()
		{
			InitializeComponent ();
		}

        private void ViewHall(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_Halls());
        }

        private void ViewLab(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_Labs());
        }

        private void adminHLback(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}