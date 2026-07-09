using SellerOps.DevExpress.Inventory.Wpf.ViewModels;

namespace SellerOps.DevExpress.Inventory.Wpf.Models
{

    public sealed class Product : ViewModelBase
    {

        public int Id { get; set; }

        public string Sku
        {
            get;
            set => SetProperty(ref field, value);
        } = string.Empty;

        public string Title
        {
            get;
            set => SetProperty(ref field, value);
        } = string.Empty;

        public string Marketplace
        {
            get;
            set => SetProperty(ref field, value);
        } = string.Empty;

        public int Quantity
        {
            get;
            set => SetProperty(ref field, value);
        }

        public decimal Price
        {
            get;
            set => SetProperty(ref field, value);
        }

        public ProductStatus Status
        {
            get;
            set => SetProperty(ref field, value);
        }

        public DateTime LastUpdated
        {
            get;
            set => SetProperty(ref field, value);
        } = DateTime.Today;
    }
}

