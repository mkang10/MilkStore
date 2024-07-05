using MilkStoreWepAPI.DAO;
using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.Models;

public partial class OrderHistory
{
    public int OrderHistoryId { get; set; }

    public int? OrderId { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? OrderStatus { get; set; }

    public virtual Order? Order { get; set; }
}
