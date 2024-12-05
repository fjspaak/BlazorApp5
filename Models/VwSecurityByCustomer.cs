using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityByCustomer
{
    public int UserId { get; set; }

    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public string? KlantCode { get; set; }

    public string? KlantNaam { get; set; }

    public string KlantLevel { get; set; } = null!;

    public bool IsCustom { get; set; }

    public bool IsDefault { get; set; }
}
