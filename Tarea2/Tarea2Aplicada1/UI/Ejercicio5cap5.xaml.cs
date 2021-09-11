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
using System.Windows.Shapes;
using Tarea2Aplicada1.Recursos;

namespace Tarea2Aplicada1.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio5cap5.xaml
    /// </summary>
    public partial class Ejercicio5cap5 : Window
    {
        Convertidor conversor = new Convertidor();
        public Ejercicio5cap5()
        {
            InitializeComponent();
        }

        private void ConversionButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = conversor.enletras(ConversionTextBox.Text);
        }

    }
    }
