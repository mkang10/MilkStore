using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class ArticleProduct
{
    public int ArticleProductId { get; set; }

    public int? ArticleId { get; set; }

    public int? ProductId { get; set; }

    public virtual Article? Article { get; set; }

    public virtual Product? Product { get; set; }
}
