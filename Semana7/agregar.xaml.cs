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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Semana7
{
    /// <summary>
    /// Lógica de interacción para agregar.xaml
    /// </summary>
    public partial class agregar : Window
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void Button_Insertar(object sender, RoutedEventArgs e)
        {

     
            PersonData personData = new PersonData();

            Person nuevaPersona = new Person
            {
                FirstName = nombre.Text,
                Address = direccion.Text,
                Phone = celular.Text,
                Active = activo.IsChecked ?? false // Si el checkbox está marcado, Active será true, de lo contrario, será false
            };

            personData.Insert(nuevaPersona);

           MessageBox.Show("La persona ha sido agregada exitosamente.");
        }



    }
}
