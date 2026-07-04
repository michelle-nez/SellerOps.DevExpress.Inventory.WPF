using System;
using SellerOps.DevExpress.Inventory.Wpf.ViewModels;

namespace SellerOps.DevExpress.Inventory.Wpf.Models;

public sealed class Product : ViewModelBase
{
    private string _sku = string.Empty;
    private string _title = string.Empty;
    private string _marketplace = string.Empty;
    private int _quantity;
    private decimal _price;
    private ProductStatus _status;
    private DateTime _lastUpdated = DateTime.Today;

    public string Sku
    {
        get => _sku;
        set => SetProperty(ref _sku, value);
    }

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public string Marketplace
    {
        get => _marketplace;
        set => SetProperty(ref _marketplace, value);
    }

    public int Quantity
    {
        get => _quantity;
        set => SetProperty(ref _quantity, value);
    }

    public decimal Price
    {
        get => _price;
        set => SetProperty(ref _price, value);
    }

    public ProductStatus Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    public DateTime LastUpdated
    {
        get => _lastUpdated;
        set => SetProperty(ref _lastUpdated, value);
    }
}
