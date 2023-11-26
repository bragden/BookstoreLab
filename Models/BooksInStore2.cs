using System;
using System.Collections.Generic;

namespace BookstoreLab.Models;

public partial class BooksInStore2
{
    public string? Title { get; set; }

    public decimal? Price { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int StoreId { get; set; }

    public int? Quantity { get; set; }

    public string Isbn13 { get; set; } = null!;
}
