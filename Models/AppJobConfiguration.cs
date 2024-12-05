using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppJobConfiguration
{
    public string ConfigurationFilter { get; set; } = null!;

    public string? ConfiguredValue { get; set; }

    public string PackagePath { get; set; } = null!;

    public string ConfiguredValueType { get; set; } = null!;
}
