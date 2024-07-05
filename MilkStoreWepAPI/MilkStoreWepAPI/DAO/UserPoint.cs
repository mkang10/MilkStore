using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class UserPoint
{
    public int PointId { get; set; }

    public int? OrderDetailId { get; set; }

    public int? Points { get; set; }

    public virtual ICollection<Gift> Gifts { get; set; } = new List<Gift>();

    public virtual OrderDetail? OrderDetail { get; set; }
}
