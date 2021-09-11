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
    /// Interaction logic for Ejercicio2cap4.xaml
    /// </summary>
    public partial class Ejercicio2cap4 : Window
    {
        int numerop;
        static int potenciap;
        public Ejercicio2cap4()
        {
            InitializeComponent();
        }

        private void ConfirmarPButton_Click(object sender, RoutedEventArgs e)
        {
            numerop = int.Parse(NumeroPTextBox.Text);
            potenciap = int.Parse(PotenciaTextBox.Text);
            ResultadoTextBox.Text = Calculo_Potencia(numerop).ToString();
        }

        public static int Calculo_Potencia(int numerop)
        {
            int proceso = 0;
            int resultado = numerop;
            do
            {
                proceso = numerop * resultado;
                resultado = proceso;
                potenciap--;
            } while (potenciap > 1);
            return resultado;
        }
    }
}
