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
    /// Interaction logic for Ejercicio1cap4.xaml
    /// </summary>
    public partial class Ejercicio1cap4 : Window
    {
        public static int numero;
        public static ListView Lista_De_Numeros_Almacenados = new ListView();

        public Ejercicio1cap4()
        {
            InitializeComponent();
        }

        private void ConfirmarButton_Click(object sender, RoutedEventArgs e)
        {
            PanelGeneral.Children.Remove(Lista_De_Numeros_Almacenados);
            numero = int.Parse(NumeroTextBox.Text);
            Tabla_De_Multiplicar();
            PanelGeneral.Children.Add(Lista_De_Numeros_Almacenados);
        }
        
        public static void Tabla_De_Multiplicar()
        {
            int j = 1;

            while(j <= 10)
            {
                int resultado;
                resultado = numero * j;
                Lista_De_Numeros_Almacenados.Items.Add(resultado);
                j++;
            }
        }
    }
}
