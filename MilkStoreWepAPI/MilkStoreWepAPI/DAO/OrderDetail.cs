using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? DiscountedPrice { get; set; }

    public int? Points { get; set; }

    public bool? IsReviewed { get; set; }

    public string? OrderStatus { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<UserPoint> UserPoints { get; set; } = new List<UserPoint>();
}
