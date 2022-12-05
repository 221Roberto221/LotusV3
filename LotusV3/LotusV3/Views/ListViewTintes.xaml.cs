using LotusV3.Models;
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
    public partial class ListViewTintes : ContentPage
    {
        public IList<Tintes> Tinte { get; private set; }
        public ListViewTintes()
        {
            InitializeComponent();
            Tinte = new List<Tintes>();

            Tinte.Add(new Tintes
           {
               Nombre = "Chocolate Cobrizo",
               Imagen = "https://botoxcapilar.org/wp-content/uploads/2020/11/mujer-con-el-pelo-te%C3%B1ido-por-primera-vez.jpg"

           });
            Tinte.Add(new Tintes
            {
                Nombre = "Castaño Claro",
                Imagen = "https://i.pinimg.com/originals/3a/52/af/3a52af4dd34f31088256512abe9ea2e1.jpg"

            });
            Tinte.Add(new Tintes
            {
                Nombre = "Rojo Cobrizo",
                Imagen = "https://i.pinimg.com/originals/02/15/5c/02155cd2cf8e7682ede74113c1d2227b.jpg"

            });
            Tinte.Add(new Tintes
            {
                Nombre = "Rubio Cenizo",
                Imagen = "https://mujersaludable10.com/wp-content/uploads/2021/08/rubio-cenizo-e1629216332399.jpg"

            });

            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Tintes SelectedItem = e.SelectedItem as Tintes;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Tintes tappedItem = e.Item as Tintes;
        }

        private async void BtnSiguiente_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MetodoDePago());
        }
    }
}