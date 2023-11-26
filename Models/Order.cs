using System;
using System.Collections.Generic;

namespace BookstoreLab.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Payment { get; set; }

    public string? Isbn13 { get; set; }

    public int? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Book? Isbn13Navigation { get; set; }
}
