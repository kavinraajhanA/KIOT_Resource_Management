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
	public partial class AdminMaint : ContentPage
	{
		public AdminMaint ()
		{
			InitializeComponent ();
		}

        private void LabMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new labmaintenance());
        }

        private void ClassMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new classmaintenance());
        }

        private void SantiMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sanitization_Maintenance());
        }

        private void WaterMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new watermaintenace());
        }

        

        private void AdMainBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}