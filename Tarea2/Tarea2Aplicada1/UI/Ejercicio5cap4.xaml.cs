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

namespace Tarea2Aplicada1.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio5cap4.xaml
    /// </summary>
    public partial class Ejercicio5cap4 : Window
    {
        static int numerodepersonas;
        static int edades;
        static int mayor = 0, menor = 0;
        int cont = 0;
        int total = 0;
        public Ejercicio5cap4()
        {
            InitializeComponent();
        }
        private void Confirmar_CantidadButton_Click(object sender, RoutedEventArgs e)
        {
            numerodepersonas = int.Parse(CantidadTextBox.Text);
            EdadLabel.Visibility = Visibility.Visible;
            PersonaTextBox.Visibility = Visibility.Visible;
            PersonaButton.Visibility = Visibility.Visible;
        }

        private void PersonaButton_Click(object sender, RoutedEventArgs e)
        {
            
            edades = int.Parse(PersonaTextBox.Text);
            PersonaTextBox.Clear();

            for (int j = 0; j < numerodepersonas; j++)
            {
                total += edades;
                cont++;
            }

            for (int v = 0; v < numerodepersonas; v++)
            {
                if (edades > mayor)
                {
                    mayor = edades;
                }
                if (edades < menor)
                {
                    menor = edades;
                }
            }

            EdadPromedioLabel.Visibility = Visibility.Visible;
            PromedioTextBox.Visibility = Visibility.Visible;
            EdadMayorLabel.Visibility = Visibility.Visible;
            EdadMayorTextBox.Visibility = Visibility.Visible;
            EdadMenorLabel.Visibility = Visibility.Visible;
            EdadMenorTextBox.Visibility = Visibility.Visible;
            CalcularButton.Visibility = Visibility.Visible;
            SalirButton.Visibility = Visibility.Visible;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int promedioedades;
            

            promedioedades = Convert.ToInt32(total / cont);
            PromedioTextBox.Text = promedioedades.ToString();
            
            EdadMayorTextBox.Text = mayor.ToString();
            EdadMenorTextBox.Text = menor.ToString();
        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            Close();      
        }

    }
  
}

