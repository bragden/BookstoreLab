using System;
using System.Collections.Generic;

namespace BookstoreLab.Models;

public partial class Book
{
    public string Isbn13 { get; set; } = null!;

    public string? Title { get; set; }

    public string? Language { get; set; }

    public decimal? Price { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? AuthorId { get; set; }

    public int? PublisherId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<InventoryBalance> InventoryBalances { get; set; } = new List<InventoryBalance>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Publisher? Publisher { get; set; }
}
