using LotusV3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LotusV3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetodoDePago : ContentPage
    {
        public MetodoDePago()
        {
            InitializeComponent();
        }

        private async void Siguiente_Clicked(object sender, EventArgs e)
        {
            await this.DisplayAlert("Felicidades!", "Cita programada con exito!", "Ok", "Continuar");
            await Navigation.PushAsync(new HomePage());
        }
    }
}