using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace adivina_el_numero
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
             //botones apagados
            InitializeComponent();
            fondo.BackgroundColor = Color.Black;
            
            Cont1.IsVisible = false;
            Cont2.IsVisible = false;
            Cont3.IsVisible = false;
            Cont4.IsVisible = false;
            Cont5.IsVisible = false;
            Cont6.IsVisible = false;
            Cont7.IsVisible = false;
            Cont8.IsVisible = false;
            Cont9.IsVisible = false;
            Cont10.IsVisible = false;
            Cont11.IsVisible = false;
            salir.IsVisible = false;
            resul.IsVisible = false;
            menu.IsVisible = false;
            lblinicio.IsVisible = false;
            lblInstru.IsVisible = false;
            menu.Items.Add("-->Adivinando su numero");
            menu.Items.Add("-->Adivinando tu Fecha de Cumpleaños");
            
        }
        private void inicio_Clicked(object sender, EventArgs e)
        {
            lblInstru.IsVisible = true;
            lblinicio.IsVisible = true;
            menu.IsVisible = true;
            inicio.IsVisible = false;
            ini.IsVisible = false;
        }
        private void menu_SelectedIndexChanged(object sender, EventArgs e) 
        {
            String op = menu.SelectedItem.ToString();
            
            

            if (op== "-->Adivinando su numero")
            {
                menu.IsVisible = false;
                lblinicio.Text = "Bienvenido";
                lblInstru.Text = "Necesito que piense en un Número...";
                Cont1.IsVisible = true;
            }
            else {
                menu.IsVisible = false;
                lblinicio.Text = "Bienvenido";
                lblInstru.Text = "Piense en la fecha del día de su Cumpleaños...";
                Cont6.IsVisible = true;
            };

        }

        private void Cont1_Clicked(object sender, EventArgs e)
        {
            lblinicio.Text = "Seguir las instrucciones  ⬇ ";
            lblInstru.Text = "A ese numero que pensó multipliquelo por 2 ";
         
        
            Cont1.IsVisible = false;
            Cont2.IsVisible = true;
        }

        private void Cont2_Clicked(object sender, EventArgs e)
        {
            lblInstru.Text = "Al resultado le suma 8 ";
            Cont2.IsVisible = false;
            Cont3.IsVisible = true;
        }

        private void Cont3_Clicked(object sender, EventArgs e)
        {
            lblInstru.Text = "Al resultado lo multiplica por 5 ";
            Cont3.IsVisible = false;
            Cont4.IsVisible = true;
            
        }

        private void Cont4_Clicked(object sender, EventArgs e)
        {
            resul.IsVisible = true;
            lblInstru.Text = "";
            Cont4.IsVisible = false;
            Cont5.IsVisible = true;
            lblinicio.Text = "El paso final...";
        }

        private void Cont5_Clicked(object sender, EventArgs e)
        {
            var result = resul.Text;
                salir.IsVisible = true;
                result = result.Remove(resul.Text.Length - 1);
                var result1 = Convert.ToInt32(result);
                result1 = result1 - 4;
                lblinicio.Text = "Usted pensó en el Numero: ";
                Ultres.Text = result1.ToString();
                resul.IsVisible = false;
                Cont5.IsVisible = false;
                salir.IsVisible = true;
            
        }

        private void Cont6_Clicked(object sender, EventArgs e)
        {
            lblinicio.Text = "Seguir las instrucciones  ⬇ ";
            lblInstru.Text = "Ahora a su fecha mutipliquelo por 20 ";

            Cont6.IsVisible = false;
            Cont7.IsVisible = true;
        }

        private void Cont7_Clicked(object sender, EventArgs e)
        {
            lblInstru.Text = "Al resultado dado sumale 73 ";

            Cont7.IsVisible = false;
            Cont8.IsVisible = true;
        }

        private void Cont8_Clicked(object sender, EventArgs e)
        {
            lblInstru.Text = "Ahora multiplicalo por 5 ";

            Cont8.IsVisible = false;
            Cont9.IsVisible = true;
        }

        private void Cont9_Clicked(object sender, EventArgs e)
        {
            lblInstru.Text = "Lo último al número total le suma la fecha del mes de su cumpleaños ";

            Cont9.IsVisible = false;
            Cont10.IsVisible = true;
        }

        private void Cont10_Clicked(object sender, EventArgs e)
        {
            lblInstru.Text = "";
            resul.IsVisible = true;

            Cont10.IsVisible = false;
            Cont11.IsVisible = true;
        }

        private void Cont11_Clicked(object sender, EventArgs e)
            {
                var result = resul.Text;
                var result1 = Convert.ToInt32(result);
                int resulFinal;
                resulFinal = result1 - 365;
            if (resulFinal >= 1000)
            {
                result = Convert.ToString(resulFinal);
                string pos = result.Substring(0, 2);
                    string mes = result.Substring(2, 2);
                    lblinicio.Text = "Su cumpleaños es: ";
                    switch (mes)

                    {
                        case "01":                        
                            mes = "Enero";
                            break;

                        case "02":                       
                            mes = "Febrero";
                            break;

                        case "03":                     
                            mes = "Marzo";
                            break;
                        case "04":                     
                            mes = "Abril";
                            break;
                        case "05":
                            mes = "Mayo";
                            break;
                        case "06":
                            mes = "Junio";
                            break;

                        case "07":
                            mes = "Julio";
                            break;

                        case "08":
                            mes = "Agosto";
                            break;

                        case "09":
                            mes = "Septiembre";
                            break;

                        case "10":
                            mes = "Octubre";
                            break;

                        case "11":
                            mes = "Noviembre";
                            break;

                        case "12":
                            mes = "Diciembre";
                            break;
                        default:

                        mes = "ingreso, vuelve a intentar...";
                        pos = "Error";
                        break;
                    }
                    Ultres.Text = pos + " de " + mes;



                } else {
                    result = Convert.ToString(resulFinal);
                    string pos = result.Substring(0, 1);
                    string mes = result.Substring(1, 2);
                    lblinicio.Text = "Su cumpleaños es: ";
                    switch (mes)

                    {
                        case "01":                        
                            mes = "Enero";
                            break;

                        case "02":
                        
                            mes = "Febrero";
                            break;
                        case "03":
                     
                            mes = "Marzo";
                            break;
                        case "04":
                        
                            mes = "Abril";
                            break;
                        case "05":
                            mes = "Mayo";
                            break;

                        case "06":
                            mes = "Junio";
                            break;

                        case "07":

                            mes = "Julio";
                            break;

                        case "08":
                            mes = "Agosto";
                            break;

                        case "09":
                            mes = "Septiembre";
                            break;

                        case "10":
                            mes = "Octubre";
                            break;

                        case "11":
                            mes = "Noviembre";
                            break;

                        case "12":
                            mes = "Diciembre";
                            break;
                        default:

                            mes = "ingreso, vuelve a intentar...";
                        pos = "Error";
                            break;
                    }
                    Ultres.Text = pos + " de " + mes;
                } 


                Cont10.IsVisible = false;
                resul.IsVisible = false;
                Cont11.IsVisible = false;
                salir.IsVisible = true;

            
        }

        private void salir_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

       
    }
}
