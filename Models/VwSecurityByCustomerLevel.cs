using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityByCustomerLevel
{
    public int UserId { get; set; }

    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public string KlantLevel { get; set; } = null!;
}
