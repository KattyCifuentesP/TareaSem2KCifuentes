using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSem2KCifuentes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usr = txtUsuario.Text;
            string clave = txtPassword.Text;

            await Navigation.PushAsync(new MenuPage(usr, clave));
        }
    }
}
