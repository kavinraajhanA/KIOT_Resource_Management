﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class addlab : ContentPage
	{
		public addlab ()
		{
			InitializeComponent ();
		}

        private void backadminpro(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void viewlabs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View_Labs ());
        }
    }
}