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
    public partial class ListView : ContentPage
    {
        public List<Cortes> Corte = new List<Cortes>();
        public List<Cortes> Corte2 = new List<Cortes>();
        public ListView()
        {
            InitializeComponent();
            this.Corte = new List<Cortes>();
            Cortes estilos = new Cortes()
            {
                Imagen= "https://ath2.unileverservices.com/wp-content/uploads/sites/13/2021/03/16165558/tipos-cortes-hombres-militar-684x1024.jpg",
                Nombre= "Corte militar para hombre"
            };
            this.Corte.Add(estilos);
            this.estilos.ItemsSource = this.Corte;

            this.Corte2 = new List<Cortes>();
            Cortes estilos2 = new Cortes()
            {
                Imagen = "https://ath2.unileverservices.com/wp-content/uploads/sites/13/2021/03/16174112/tipos-cortes-hombres-fade-683x1024.jpg",
                Nombre = "Corte fade para hombre"
            };
            this.Corte2.Add(estilos2);
            this.estilos2.ItemsSource = this.Corte2;

        }
    }
}