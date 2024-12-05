using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OverviewSection
{
    public int OverviewSectionId { get; set; }

    public int OverviewId { get; set; }

    public string? OverviewSectionName { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual Overview Overview { get; set; } = null!;

    public virtual ICollection<OverviewFieldOverviewSection> OverviewFieldOverviewSections { get; set; } = new List<OverviewFieldOverviewSection>();
}
