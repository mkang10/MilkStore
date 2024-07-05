using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Gift
{
    public int GiftId { get; set; }

    public int? UserId { get; set; }

    public int? PointId { get; set; }

    public string? GiftName { get; set; }

    public string? Description { get; set; }

    public DateOnly? GiftDate { get; set; }

    public virtual UserPoint? Point { get; set; }

    public virtual User? User { get; set; }
}
