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
    public partial class ListViewCortes : ContentPage
    {
        public IList<Cortes> Cortes { get; private set; }
        public ListViewCortes()
        {
            InitializeComponent();
            Cortes = new List<Cortes>();

            Cortes.Add(new Cortes
            {
                Nombre = "Corte Clasico",
                Imagen = "https://ath2.unileverservices.com/wp-content/uploads/sites/13/2021/03/16182444/tipos-cortes-hombres-clasico-532x798.jpg"

            });
            Cortes.Add(new Cortes
            {
                Nombre = "Corte Militar para Hombre",
                Imagen = "https://ath2.unileverservices.com/wp-content/uploads/sites/13/2021/03/16165558/tipos-cortes-hombres-militar-532x797.jpg"

            });
            Cortes.Add(new Cortes
            {
                Nombre = "Corte Hongo para Hombre",
                Imagen = "https://ath2.unileverservices.com/wp-content/uploads/sites/13/2021/03/16170601/tipos-cortes-hombres-hongo-532x798.jpg"

            });
            Cortes.Add(new Cortes
            {
                Nombre = "Corte Mohicano",
                Imagen = "https://ath2.unileverservices.com/wp-content/uploads/sites/13/2021/03/16194055/tipos-cortes-hombres-mohicano-532x611.jpg"

            });

            BindingContext = this;
        }



        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Cortes SelectedItem = e.SelectedItem as Cortes;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           Cortes tappedItem = e.Item as Cortes;
        }
    }
}