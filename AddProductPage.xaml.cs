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
    /// Logika interakcji dla klasy AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public IProductTypeEnums.ProductTypes ProductType { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            SetProductTypeLbl():
        }

        void SetProductTypeLbl()
        {
            switch (ProductType)
            {
                case IProductTypeEnums.ProductTypes.Soups:
                    typeLbl.Text = "Zupy";
                    break;
                case IProductTypeEnums.ProductTypes.MainDishes:
                    typeLbl.Text = "Dania Główne";
                    break;
                case IProductTypeEnums.ProductTypes.Desserts:
                    typeLbl.Text = "Desery";
                    break;
                case IProductTypeEnums.ProductTypes.Drinks:
                    typeLbl.Text = "Napoje";
                    break;
            }
        }
    }
}
