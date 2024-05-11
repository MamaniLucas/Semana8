﻿using Business;
using Entity;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Semana7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string name = txtName.Text;

            PersonBusiness business = new PersonBusiness();

            List<Person> filteredPeople = business.GetPeopleByName(name);

            dgPeople18.ItemsSource = filteredPeople;
        }

     

        private void Button_Click_find(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;

            PersonBusiness business = new PersonBusiness();
            Person person = business.GetPersonByName(name);

            if (person != null)
            {
                dgPeople18.ItemsSource = new List<Person>() { person };
            }
            else
            {
                dgPeople18.ItemsSource = null;
            }
        }

        private void Button_Click_Insertar(object sender, RoutedEventArgs e)
        {
            agregar a = new agregar();
            a.ShowDialog();
        }

        private void Button_Click_delete(object sender, RoutedEventArgs e)
        {
            eliminar b = new eliminar();
            b.ShowDialog();
        }
    }
}
