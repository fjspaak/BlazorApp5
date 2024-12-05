using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class JobPositionGroup
{
    public int JobPositionGroupId { get; set; }

    public string? JobPositionGroupCode { get; set; }

    public string? JobPositionGroupName { get; set; }

    public string? Description { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<JobPosition> JobPositions { get; set; } = new List<JobPosition>();

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();
}
