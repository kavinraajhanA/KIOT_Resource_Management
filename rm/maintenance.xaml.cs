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
	public partial class maintenance : ContentPage
	{
		public maintenance ()
		{
			InitializeComponent ();
		}

        private void LabMain(object sender, EventArgs e)
        {
			Navigation.PushAsync(new labmaintainance());
        }

        private void ClassMain(object sender, EventArgs e)
        {
			Navigation.PushAsync(new classroomquery());
        }

        private void SantiMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new santization());
        }

        private void WaterMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new water());
        }

        private void MainBack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserMain());
        }
    }
}