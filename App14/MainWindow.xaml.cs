using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace App14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name="Капуста",
                Price=100,
                Image="Data/Капуста.jpg",
                Categorie=Categorie.Food
            });
            products.Add(new Product()
            {
                Name = "Телевизор",
                Price = 100000,
                Image = "Data/Телевизор.jpg",
                Categorie=Categorie.Appliance
            });
            listBox.ItemsSource = products;


        }
    }
}
