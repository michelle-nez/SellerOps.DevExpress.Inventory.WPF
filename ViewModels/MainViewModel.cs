using SellerOps.DevExpress.Inventory.Wpf.Models;
using System.Collections.ObjectModel;

namespace SellerOps.DevExpress.Inventory.Wpf.ViewModels
{
    public sealed class MainViewModel : ViewModelBase
    {

        private int _newProductNumber = 1000;

        public ObservableCollection<Product> Products { get; } = [];

        public ProductStatus[] StatusOptions { get; } = Enum.GetValues<ProductStatus>();

        public RelayCommand AddProductCommand { get; }

        public RelayCommand DeleteSelectedCommand { get; }

        public Product? SelectedProduct
        {
            get;
            set
            {
                if (SetProperty(ref field, value))
                {
                    DeleteSelectedCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public int TotalProducts => Products.Count;

        public int LowStockCount => Products.Count(product => product.Quantity <= 5 || product.Status == ProductStatus.LowStock);

        public int ReviewCount => Products.Count(product => product.Status == ProductStatus.NeedsReview);

        public decimal InventoryValue => Products.Sum(product => product.Quantity * product.Price);

        public MainViewModel()
        {
            AddProductCommand = new RelayCommand(_ => AddNewProduct());
            DeleteSelectedCommand = new RelayCommand(_ => DeleteSelectedProduct(), _ => SelectedProduct is not null);

            AddProduct(new Product
            {
                Sku = "WP-CAT6-001",
                Title = "Cat6 HDMI Wall Plate",
                Marketplace = "Amazon",
                Quantity = 24,
                Price = 18.99m,
                Status = ProductStatus.Active,
                LastUpdated = DateTime.Today.AddDays(-1)
            });

            AddProduct(new Product
            {
                Sku = "USB-C-PLATE-002",
                Title = "USB-C and USB-A Outlet Wall Plate",
                Marketplace = "Shopify",
                Quantity = 5,
                Price = 27.50m,
                Status = ProductStatus.LowStock,
                LastUpdated = DateTime.Today.AddDays(-2)
            });

            AddProduct(new Product
            {
                Sku = "FIBER-LC-003",
                Title = "LC Duplex Fiber Wall Plate",
                Marketplace = "eBay",
                Quantity = 11,
                Price = 22.95m,
                Status = ProductStatus.NeedsReview,
                LastUpdated = DateTime.Today.AddDays(-4)
            });
        }

        private void AddNewProduct()
        {
            _newProductNumber++;

            AddProduct(new Product
            {
                Sku = $"NEW-SKU-{_newProductNumber}",
                Title = "New Marketplace Product",
                Marketplace = "Amazon",
                Quantity = 1,
                Price = 9.99m,
                Status = ProductStatus.Draft,
                LastUpdated = DateTime.Today
            });
        }

        private void DeleteSelectedProduct()
        {
            if (SelectedProduct is null)
            {
                return;
            }

            Products.Remove(SelectedProduct);
            SelectedProduct = null;
            RefreshMetrics();
        }

        private void AddProduct(Product product)
        {
            product.PropertyChanged += (_, _) => RefreshMetrics();
            Products.Add(product);
            RefreshMetrics();
        }

        private void RefreshMetrics()
        {
            OnPropertyChanged(nameof(TotalProducts));
            OnPropertyChanged(nameof(LowStockCount));
            OnPropertyChanged(nameof(ReviewCount));
            OnPropertyChanged(nameof(InventoryValue));
        }


    }
}
