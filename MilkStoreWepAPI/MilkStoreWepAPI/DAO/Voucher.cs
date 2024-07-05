using System;
using System.Collections.Generic;

namespace MilkStoreWepAPI.DAO;

public partial class Voucher
{
    public int VoucherId { get; set; }

    public string? VoucherCode { get; set; }

    public decimal? Value { get; set; }

    public string? VoucherType { get; set; }

    public string? Condition { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public decimal? MinimumSpend { get; set; }

    public int? OrderId { get; set; }

    public virtual Order? Order { get; set; }
}
