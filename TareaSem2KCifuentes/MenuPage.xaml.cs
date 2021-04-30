using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSem2KCifuentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblPassword.Text = clave;
        }

        private async void btnGrades_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GradesPage());
        }
    }
}