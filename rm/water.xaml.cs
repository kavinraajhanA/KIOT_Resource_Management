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
	public partial class water : ContentPage
	{
		public water ()
		{
			InitializeComponent ();
		}

        private void WatBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void WatSubmit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new maintenance());
        }
    }
}