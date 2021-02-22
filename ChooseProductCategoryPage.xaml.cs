using System;
using System.Collections.Generic;
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

namespace Baza_Danych
{
    /// <summary>
    /// Logika interakcji dla klasy ChooseProductCategoryPage.xaml
    /// </summary>
    public partial class ChooseProductCategoryPage : Page
    {
        //public Window mainWindow { get; set; }
        public ChooseProductCategoryPage()
        {
            InitializeComponent();
        }

        private void Soups_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage soupsPage = new ProductsPage();
            soupsPage.ProductType = IProductTypeEnums.ProductTypes.Soups;
            Application.Current.MainWindow.Content = soupsPage;
        }

        private void MainDishes_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage mainDishesPage = new ProductsPage();
            mainDishesPage.ProductType = IProductTypeEnums.ProductTypes.MainDishes;
            Application.Current.MainWindow.Content = mainDishesPage;
        }

        private void Desserts_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage dessertsPage = new ProductsPage();
            dessertsPage.ProductType = IProductTypeEnums.ProductTypes.Desserts;
            Application.Current.MainWindow.Content = dessertsPage;
        }

        private void Drinks_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProductsPage drinksPage = new ProductsPage();
            drinksPage.ProductType = IProductTypeEnums.ProductTypes.Drinks;
            Application.Current.MainWindow.Content = drinksPage;
        }
    }
}
