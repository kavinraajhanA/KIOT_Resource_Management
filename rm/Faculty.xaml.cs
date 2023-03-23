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
	public partial class Faculty : ContentPage
	{
		public Faculty ()
		{
			InitializeComponent ();
		}

        private void fac1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FacultyProfile());
        }

        private void backadminpro(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}