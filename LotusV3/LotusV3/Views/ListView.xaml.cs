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
        public List<Jugador> Jugadores = new List<Jugador>();
        public ListView()
        {
            InitializeComponent();
            this.Jugadores=new List<Jugador>();
            Jugador jugador = new Jugador()
            {
                Imagen = "https://static1-es.millenium.gg/articles/0/51/23/0/@/284159-faker-t1-worlds-article_m-1.jpg",
                Nombre = "Faker",
                Equipo = "T1"
            };
            this.Jugadores.Add(jugador);
            this.jugadores.ItemsSource = this.Jugadores;
        }
    }
}