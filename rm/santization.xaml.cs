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
	public partial class santization : ContentPage
	{
		public santization ()
		{
			InitializeComponent ();
		}

        private void SanBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();  
        }

        private void SanSubmit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new maintenance());
        }
    }
}