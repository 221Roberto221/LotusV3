﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LotusV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BtnCalendario.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Calendario());
            };
        }

        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void BtnListView_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ListView());
        }
    }
}