using System;
using System.Collections.Generic;
using System.Text;

namespace SellerOps.DevExpress.Inventory.Wpf.Models
{
    public sealed class Product : ViewModelBase
    {
        private string _sku = string.Empty;

        private string _title = string.Empty;

        private string _marketplace = string.Empty;

        private int _quantity;

        private decimal _price;

        private ProductStatus _status;

        private DateTime _lastUpdated = DateTime.Today;
    }
}
