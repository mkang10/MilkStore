using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class ChatHistory
{
    public int ChatHistoryId { get; set; }

    public int? ChatId { get; set; }

    public int? UserId { get; set; }

    public string? Message { get; set; }

    public DateTime? SendDate { get; set; }

    public virtual Chat? Chat { get; set; }

    public virtual User? User { get; set; }
}
