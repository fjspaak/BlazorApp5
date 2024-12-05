using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityByOverview
{
    public int UserId { get; set; }

    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public int OverviewId { get; set; }

    public string? OverviewName { get; set; }

    public bool IsCustom { get; set; }

    public string RechtenVerkegenVia { get; set; } = null!;
}
