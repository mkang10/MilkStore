using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public string? ProductType { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public decimal? Weight { get; set; }

    public string? Brand { get; set; }

    public decimal? FatContent { get; set; }

    public decimal? Volume { get; set; }

    public string? PackagingType { get; set; }

    public string? StorageInstructions { get; set; }

    public string? Ingredients { get; set; }

    public virtual ICollection<ArticleProduct> ArticleProducts { get; set; } = new List<ArticleProduct>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
