using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Proyecto
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        async void Login_Clicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new TabsPage());
        }
    }
}
