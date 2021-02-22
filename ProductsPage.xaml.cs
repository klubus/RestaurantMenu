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
    /// Logika interakcji dla klasy ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        public IProductTypeEnums.ProductTypes ProductType{get; set;}
        public ProductsPage()
        {
            InitializeComponent();
            SetProductTypeLabel();
        }

        private void SetProductTypeLabel()
        {
            switch(ProductType)
            {
                case IProductTypeEnums.ProductTypes.Soups:
                    ProductTypeLbl.Content = "Zupy";
                    break;
                case IProductTypeEnums.ProductTypes.MainDishes:
                    ProductTypeLbl.Content = "Dania Główne";
                    break;
                case IProductTypeEnums.ProductTypes.Desserts:
                    ProductTypeLbl.Content = "Desery";
                    break;
                case IProductTypeEnums.ProductTypes.Drinks:
                    ProductTypeLbl.Content = "Napoje";
                    break;
            }
        }
    }
}
