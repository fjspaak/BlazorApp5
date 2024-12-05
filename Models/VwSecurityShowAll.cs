using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityShowAll
{
    public string? LoginName { get; set; }

    public string? UserName { get; set; }

    public string UserGroup { get; set; } = null!;

    public string? OverviewName { get; set; }

    public string? OrganisationName { get; set; }
}
