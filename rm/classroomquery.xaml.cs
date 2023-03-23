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
	public partial class classroomquery : ContentPage
	{
		public classroomquery ()
		{
			InitializeComponent ();
		}

        private void CQBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void CQSubmit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new maintenance());
        }
    }
}