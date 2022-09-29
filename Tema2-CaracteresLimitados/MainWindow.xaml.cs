using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LimiteCaracteres_TextBlock.Text = caracteres + LimiteCaracteres_TextBlock.Text;
        }
        //public int cont = 0;
        public int maximoCaracteres = 140;
        private int caracteres = 0;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            caracteres = Caracteres_TextBox.Text.Length;
            if (caracteres < maximoCaracteres)
            {
                LimiteCaracteres_TextBlock.Text = caracteres + "/140"; 
            }
            else if(caracteres >= maximoCaracteres)
            {
                LimiteCaracteres_TextBlock.Text = caracteres + "/140";
                Caracteres_TextBox.IsReadOnly = true;
            }
        }

        private void ApretaEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                LimiteCaracteres_TextBlock.Text += "\n";
        }

    }
}
