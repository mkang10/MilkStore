using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Point
{
    public int PointId { get; set; }

    public int? UserId { get; set; }

    public int? Points { get; set; }
}
