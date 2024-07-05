using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Like
{
    public int LikeId { get; set; }

    public int? UserId { get; set; }

    public int? ArticleId { get; set; }

    public DateOnly? LikedDate { get; set; }

    public virtual Article? Article { get; set; }

    public virtual User? User { get; set; }
}
