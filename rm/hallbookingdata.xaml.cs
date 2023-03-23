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
	public partial class hallbookingdata : ContentPage
	{
		public hallbookingdata ()
		{
			InitializeComponent ();
		}

        private void HBDback(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}