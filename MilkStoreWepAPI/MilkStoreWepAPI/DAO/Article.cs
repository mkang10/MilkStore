using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Article
{
    public int ArticleId { get; set; }

    public int? UserId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public DateOnly? PublishDate { get; set; }

    public virtual ICollection<ArticleProduct> ArticleProducts { get; set; } = new List<ArticleProduct>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual User? User { get; set; }
}
