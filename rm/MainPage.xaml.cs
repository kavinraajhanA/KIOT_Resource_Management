using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CC01(object sender, EventArgs e)
        {
            Navigation.PushAsync(new bookinglab());
        }

        private void bookinback(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void CC02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new bookinglab());
        }

        private void CC03(object sender, EventArgs e)
        {
            Navigation.PushAsync(new bookinglab());
        }

        private void CC04(object sender, EventArgs e)
        {
            Navigation.PushAsync(new bookinglab());
        }
    }
}
