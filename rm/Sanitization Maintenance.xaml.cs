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
	public partial class Sanitization_Maintenance : ContentPage
	{
		public Sanitization_Maintenance ()
		{
			InitializeComponent ();
		}

        private void SMBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}