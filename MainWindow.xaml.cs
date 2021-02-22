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

namespace Baza_Danych
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

        private void Soups_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage soupsPage = new ProductsPage();
            soupsPage.ProductType = IProductTypeEnums.ProductTypes.Soups;
            this.Content = soupsPage;
        }

        private void MainDishes_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage mainDishesPage = new ProductsPage();
            mainDishesPage.ProductType = IProductTypeEnums.ProductTypes.MainDishes;
            this.Content = mainDishesPage;
        }

        private void Desserts_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage dessertsPage = new ProductsPage();
            dessertsPage.ProductType = IProductTypeEnums.ProductTypes.Desserts;
            this.Content = dessertsPage;
        }

        private void Drinks_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage drinksPage = new ProductsPage();
            drinksPage.ProductType = IProductTypeEnums.ProductTypes.Drinks;
            this.Content = drinksPage;
        }
    }
}
