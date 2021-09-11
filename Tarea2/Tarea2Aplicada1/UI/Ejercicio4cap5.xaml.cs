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
    /// Interaction logic for Ejercicio4cap5.xaml
    /// </summary>
    public partial class Ejercicio4cap5 : Window
    {
        int numero;
        public Ejercicio4cap5()
        {
            InitializeComponent();
        }

        private void FactorialButton_Click(object sender, RoutedEventArgs e)
        {
            numero = int.Parse(FactorialTextBox.Text);
            ResultadoTextBox.Text = Factorial(numero).ToString();
        }

        public static int Factorial(int ingreso)
        {
            int resultado = 1;

            for (int j = 1; j <= ingreso; j++)
            {
                resultado *= j;
            }
            return resultado;
        }
    }
}
