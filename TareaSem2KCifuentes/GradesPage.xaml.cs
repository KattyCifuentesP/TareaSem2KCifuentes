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
    public partial class GradesPage : ContentPage
    {
        public GradesPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor1 = Convert.ToDouble(txtNotaEP.Text);
                double valor2 = Convert.ToDouble(txtExamenEP.Text);
                double valor3 = Convert.ToDouble(txtNotaEF.Text);
                double valor4 = Convert.ToDouble(txtExamenEF.Text);

                double NotaEPPrc = valor1 * 0.3;
                double ExamenEPPrc = valor2 * 0.2;
                double NotaEFPrc = valor3 * 0.3;
                double ExamenEFPrc = valor4 * 0.2;

                txtNotaEPPrc.Text = NotaEPPrc.ToString();
                txtExamenEPPrc.Text = ExamenEPPrc.ToString();
                txtNotaEFPrc.Text = NotaEFPrc.ToString();
                txtExamenEFPrc.Text = ExamenEFPrc.ToString();

                double NotaParcEP = NotaEPPrc + ExamenEPPrc;

                txtNotaParcialEP.Text = NotaParcEP.ToString();

                double NotaParcEF = NotaEFPrc + ExamenEFPrc;

                txtNotaParcialEF.Text = NotaParcEF.ToString();

                double NotaFinal = NotaParcEP + NotaParcEF;

                txtNotaF.Text = NotaFinal.ToString();

                if (NotaFinal >= 7)
                {
                    txtEstado.Text = "Aprobado";
                }
                else if (NotaFinal >= 5 && NotaFinal <= 6.9)
                {
                    txtEstado.Text = "Complementario";
                }
                else
                {
                    txtEstado.Text = "Reprobado";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "gracias");
            }
        }
    }
}