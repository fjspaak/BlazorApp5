using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwFolderList
{
    public int? FolderId { get; set; }

    public int? LevelId { get; set; }

    public string? FullPathFolderId { get; set; }

    public string? FullPathFolderName { get; set; }

    public string? FullPathSortOrderCode { get; set; }
}
