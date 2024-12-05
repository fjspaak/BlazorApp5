using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class JobPosition
{
    public int JobPositionId { get; set; }

    public int? JobPositionGroupId { get; set; }

    public string? JobPositionCode { get; set; }

    public string? JobPositionName { get; set; }

    public string? ExternalReference { get; set; }

    public string? GlobalReference { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime MetaCreationDate { get; set; }

    public DateTime MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual JobPositionGroup? JobPositionGroup { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
