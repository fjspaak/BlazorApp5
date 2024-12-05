using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwRegistryTreeList
{
    public int? RegistryTreeId { get; set; }

    public int? LevelId { get; set; }

    public string? FullPathRegistryTreeId { get; set; }

    public string? FullPathRegistryTreeName { get; set; }
}
