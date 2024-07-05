using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Chat
{
    public int ChatId { get; set; }

    public int? UserId { get; set; }

    public string? Message { get; set; }

    public DateTime? SendDate { get; set; }

    public virtual ICollection<ChatHistory> ChatHistories { get; set; } = new List<ChatHistory>();

    public virtual User? User { get; set; }
}
