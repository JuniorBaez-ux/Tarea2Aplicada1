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
using Tarea2Aplicada1.UI;

namespace Tarea2Aplicada1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1cap4 ejercicio1Cap4 = new Ejercicio1cap4();
            ejercicio1Cap4.Show();
        }

        private void Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2cap4 ejercicio2Cap4 = new Ejercicio2cap4();
            ejercicio2Cap4.Show();
        }

        private void Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5cap4 ejercicio5cap4 = new Ejercicio5cap4();
            ejercicio5cap4.Show();
        }
        private void Ejercicio4cap5_Click(object sender, RoutedEventArgs e) 
        {
            Ejercicio4cap5 ejercicio4cap5 = new Ejercicio4cap5();
            ejercicio4cap5.Show();
        }

        private void Ejercicio5cap5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5cap5 ejercicio5cap5 = new Ejercicio5cap5();
            ejercicio5cap5.Show();
        }
    }
}
