using SellerOps.DevExpress.Inventory.Wpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SellerOps.DevExpress.Inventory.Wpf.ViewModels
{
    public sealed class MainViewModel
    {
        private Product? _selectedProduct;
        private int _newProductNumber = 1000;

        public  ObservableCollection<Product> Products { get; } = new();
        


    }
}
