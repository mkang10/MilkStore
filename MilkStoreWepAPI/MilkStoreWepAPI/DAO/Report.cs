using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Report
{
    public int ReportId { get; set; }

    public int? UserId { get; set; }

    public int? ArticleId { get; set; }

    public int? ProductId { get; set; }

    public string? ReportContent { get; set; }

    public DateOnly? ReportDate { get; set; }

    public virtual Article? Article { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
