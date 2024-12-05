using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwUserOrganisationAllocation
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? OrgCustomAllocations { get; set; }

    public string? OrgDefaultAllocations { get; set; }

    public int? NrOfAllocations { get; set; }

    public int? NrOfCustomAllocations { get; set; }

    public int? NrOfDefaultAllocations { get; set; }

    public int? NrOfRulesAllocations { get; set; }
}
