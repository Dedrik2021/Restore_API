using System;

namespace API.RequestHelper;

public class ProductParams
{
    public string? Brands { get; set; }
    public string? Types { get; set; }
    public string? OrderBy { get; set; }
    public string? SearchTerm { get; set; }

}
