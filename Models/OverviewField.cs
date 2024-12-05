using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OverviewField
{
    public int OverviewFieldId { get; set; }

    public string? OverviewFieldName { get; set; }

    public string? Label { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<OverviewFieldOverviewSection> OverviewFieldOverviewSections { get; set; } = new List<OverviewFieldOverviewSection>();

    public virtual ICollection<OverviewFieldOverview> OverviewFieldOverviews { get; set; } = new List<OverviewFieldOverview>();
}
