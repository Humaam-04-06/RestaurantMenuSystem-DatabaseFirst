using System;
using System.Collections.Generic;

namespace RestaurantMenuSystem.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }
}
