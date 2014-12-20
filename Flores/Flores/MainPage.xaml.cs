using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Coding4Fun.Phone.Controls;
using Flores.Paises;

namespace Flores
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        void about_Completed(object sender, PopUpEventArgs<object, PopUpResult> e)
        {
            //add some code here
        }

        #region NORTE
        private void TextBlock_Tap_Islandia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Islandia();
            p.Show();
        }

        private void TextBlock_Tap_Finlandia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Finlandia();
            p.Show();
        }

        private void TextBlock_Tap_Feroe(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Feroe();
            p.Show();
        }

        private void TextBlock_Tap_Noruega(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Noruega();
            p.Show();
        }
        #endregion

        #region OESTE
        private void TextBlock_Tap_Escocia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Escocia();
            p.Show();
        }

        private void TextBlock_Tap_Francia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Francia();
            p.Show();
        }

        private void TextBlock_Tap_Gales(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Gales();
            p.Show();
        }

        private void TextBlock_Tap_Irlanda(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Irlanda();
            p.Show();
        }

        private void TextBlock_Tap_IrlandaNorte(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new IrlandaNorte();
            p.Show();
        }

        private void TextBlock_Tap_Inglaterra(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Inglaterra();
            p.Show();
        }

        private void TextBlock_Tap_PaisesBajos(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new PaisesBajos();
            p.Show();
        }

        #endregion

        #region CENTRAL
        private void TextBlock_Tap_Alemania(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Alemania();
            p.Show();
        }

        private void TextBlock_Tap_Austria(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Austria();
            p.Show();
        }
        private void TextBlock_Tap_Croacia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Croacia();
            p.Show();
        }
        private void TextBlock_Tap_Eslovaquia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Eslovaquia();
            p.Show();
        }

        private void TextBlock_Tap_Eslovenia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Eslovenia();
            p.Show();
        }

        private void TextBlock_Tap_Estonia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Estonia();
            p.Show();
        }

        private void TextBlock_Tap_Hungria(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Hungria();
            p.Show();
        }

        private void TextBlock_Tap_Letonia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Letonia();
            p.Show();
        }

        private void TextBlock_Tap_Lituania(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Lituania();
            p.Show();
        }

        private void TextBlock_Tap_Polonia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Polonia();
            p.Show();
        }

        private void TextBlock_Tap_RepCheca(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new RepCheca();
            p.Show();
        }

        private void TextBlock_Tap_Suiza(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Suiza();
            p.Show();
        }
        #endregion

        #region SUR
        private void TextBlock_Tap_Espana(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Espana();
            p.Show();
        }

        private void TextBlock_Tap_Italia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Italia();
            p.Show();
        }

        private void TextBlock_Tap_Malta(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Malta();
            p.Show();
        }

        private void TextBlock_Tap_Monaco(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Monaco();
            p.Show();
        }

        private void TextBlock_Tap_Portugal(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Portugal();
            p.Show();
        }
        #endregion

        #region SUDESTE
        private void TextBlock_Tap_Albania(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Albania();
            p.Show();
        }
        private void TextBlock_Tap_Bosnia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Bosnia();
            p.Show();
        }
        private void TextBlock_Tap_Bulgaria(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Bulgaria();
            p.Show();
        }
        private void TextBlock_Tap_Chipre(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Chipre();
            p.Show();
        }
        private void TextBlock_Tap_Grecia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Grecia();
            p.Show();
        }
        private void TextBlock_Tap_Macedonia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Macedonia();
            p.Show();
        }
        private void TextBlock_Tap_Rumania(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Rumania();
            p.Show();
        }
        private void TextBlock_Tap_Serbia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Serbia();
            p.Show();
        }
        private void TextBlock_Tap_Turquia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Turquia();
            p.Show();
        }
        #endregion

        #region ORIENTAL
        private void TextBlock_Tap_Armenia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Armenia();
            p.Show();
        }
        private void TextBlock_Tap_Bielorrusia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Bielorrusia();
            p.Show();
        }
        private void TextBlock_Tap_Rusia(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Rusia();
            p.Show();
        }
        private void TextBlock_Tap_Ucrania(object sender, GestureEventArgs e)
        {
            AboutPrompt p = new AboutPrompt();
            p.Title = "";
            p.Body = new Ucrania();
            p.Show();
        }
        #endregion
    }
}