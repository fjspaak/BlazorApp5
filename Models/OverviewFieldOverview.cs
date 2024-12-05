using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OverviewFieldOverview
{
    public int OverviewOverviewFieldId { get; set; }

    public int OverviewId { get; set; }

    public int OverviewFieldId { get; set; }

    public string? SortOrderCode { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual Overview Overview { get; set; } = null!;

    public virtual OverviewField OverviewField { get; set; } = null!;
}
