using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? UserId { get; set; }

    public int? ArticleId { get; set; }

    public string? CommentContent { get; set; }

    public DateOnly? CommentDate { get; set; }

    public virtual Article? Article { get; set; }

    public virtual User? User { get; set; }
}
