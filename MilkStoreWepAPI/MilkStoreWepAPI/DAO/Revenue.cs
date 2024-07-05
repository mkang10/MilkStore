using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Revenue
{
    public int RevenueId { get; set; }

    public int? OrderId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? RevenueDate { get; set; }

    public decimal? Amount { get; set; }

    public string? Description { get; set; }

    public virtual Order? Order { get; set; }

    public virtual User? User { get; set; }
}
