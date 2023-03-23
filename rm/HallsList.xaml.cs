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
    public partial class HallsList : ContentPage
    {
        public HallsList()
        {
            InitializeComponent();
        }

        private void Hall1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new seminarhall());
        }

        private void HallsListBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}