using LotusV3.Tables;
using LotusV3.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LotusV3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());

            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed User Name and Password", "Yes", "Cancel");
                    if (result)
                        await Navigation.PushAsync(new MainPage());
                    else
                    {
                        await Navigation.PushAsync(new MainPage());
                    }
                });
            }
        }

        private async void NuevoUsuario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}
