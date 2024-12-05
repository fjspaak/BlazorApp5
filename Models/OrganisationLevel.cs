using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OrganisationLevel
{
    public int OrganisationLevelId { get; set; }

    public string? OrganisationLevelCode { get; set; }

    public string? OrganisationLevelName { get; set; }

    public string? Remarks { get; set; }

    public string? CodeReference { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<User> UserCustomOrganisationLevels { get; set; } = new List<User>();

    public virtual ICollection<User> UserDefaultOrganisationLevels { get; set; } = new List<User>();
}
