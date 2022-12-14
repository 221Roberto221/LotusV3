using LotusV3.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LotusV3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Registrar_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text,
            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Felicidades!", "Usuario registrado con exito!", "Ok", "Continuar");
                if (result)
                    await Navigation.PushAsync(new MainPage());
            });

        }

        private async void CorreoElectronico_Clicked(object sender, EventArgs e)
        {
            var mensaje = new EmailMessage(entryAsunto.Text, "<h1>Bienvenido</h1><span>Puede hacer uso de su membresia</span>", entryMail.Text);
            mensaje.BodyFormat = EmailBodyFormat.Html;
            await Email.ComposeAsync(mensaje);
        }
    }
}