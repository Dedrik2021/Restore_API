using System;

namespace API.RequestHelpers;

public class PaginationMetadata
{
    public int TotalCount { get; set; }  
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    // public bool HasPreviousPage => CurrentPage > 1;
    // public bool HasNextPage => CurrentPage < TotalPages;
}
