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
    public partial class usermain : ContentPage
    {
        public usermain()
        {
            InitializeComponent();
        }

        private void booking(object sender, EventArgs e)
        {
            Navigation.PushAsync(new bookingHandL());

        }

        private void maintain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new maintenance());
        }

        private void status(object sender, EventArgs e)
        {
            Navigation.PushAsync(new status());
        }
    }
}