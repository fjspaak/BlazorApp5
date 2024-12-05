using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Kpi
{
    public int KpiId { get; set; }

    public int? ScaleLkpId { get; set; }

    public string? KpiName { get; set; }

    public string? Description { get; set; }

    public string? KpiGroup { get; set; }

    public string? Remarks { get; set; }

    public string? Formula { get; set; }

    public string? NewsMessage { get; set; }

    public string? DataFields { get; set; }

    public string? Frequency { get; set; }

    public bool IsBiggerBetter { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? NormValueTopOfMin { get; set; }

    public int? NormValueMinOfTop { get; set; }

    public bool IsAggregable { get; set; }

    public bool IsAggregableByOrganisation { get; set; }

    public bool IsAggregableByTime { get; set; }

    public bool? IsEnabled { get; set; }

    public string? Units { get; set; }

    public string? Scale { get; set; }

    public string? Scope { get; set; }

    public string? CodeReference { get; set; }

    public string? GlobalReference { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<KpiUser> KpiUsers { get; set; } = new List<KpiUser>();

    public virtual AppLookupCode? ScaleLkp { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();
}
