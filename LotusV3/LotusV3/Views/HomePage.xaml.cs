using System;
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
            BtnCalendario1.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Calendario());
            };
            BtnCalendario2.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Calendario());
            };
            BtnCalendario3.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Calendario());
            };
            //BtnMetodo.Clicked += (sender, e) =>
            //{
            //    Navigation.PushAsync(new MetodoDePago());
            //};
            //BtnTinte.Clicked += (sender, e) =>
            //{
            //    Navigation.PushAsync(new ListViewTintes());
            //};
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //private async void BtnListViewCortes_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ListView());
        //}
    }
}