using Data;
using Entity;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Semana7
{
    /// <summary>
    /// Lógica de interacción para eliminar.xaml
    /// </summary>
    public partial class eliminar : Window
    {
        public eliminar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int codigoCliente;

            

            if (!int.TryParse(codigo.Text, out codigoCliente))
            {
                MessageBox.Show("Por favor, ingresa un código de cliente.");
                return;
            }
            PersonData personData = new PersonData();

            
            personData.Delete(codigoCliente);

        }
    }
}
