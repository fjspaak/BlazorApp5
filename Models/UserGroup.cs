using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class UserGroup
{
    public int UserGroupId { get; set; }

    public string? UserGroupCode { get; set; }

    public string? UserGroupName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<UserUserGroup> UserUserGroups { get; set; } = new List<UserUserGroup>();
}
