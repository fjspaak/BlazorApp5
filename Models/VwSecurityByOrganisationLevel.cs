using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityByOrganisationLevel
{
    public int UserId { get; set; }

    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public string OrganisatieLevel { get; set; } = null!;
}
