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
    public partial class Adminmain : ContentPage
    {
        public Adminmain()
        {
            InitializeComponent();
        }

        private void adminpro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new adminpro());
        }

        private void Staffreq(object sender, EventArgs e)
        {
            Navigation.PushAsync(new staffreq());
        }

        private void adminMain(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminMaint());
        }

        private void AdminHL(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminBookHL());
        }

        private void view_halls_labs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_halls_labs());
        }

        private void adminstatus(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Statusadmin());
        }
    }
}