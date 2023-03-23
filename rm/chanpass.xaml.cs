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
	public partial class chanpass : ContentPage
	{
		public chanpass ()
		{
			InitializeComponent ();
		}

        private void PassSub(object sender, EventArgs e)
        {
            Navigation.PushAsync(new adminpro());
        }

        private void backadminpro(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}