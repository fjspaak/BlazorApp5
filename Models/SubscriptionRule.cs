using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SubscriptionRule
{
    public int SubscriptionRuleId { get; set; }

    public int? SubscriptionId { get; set; }

    public int? UserGroupId { get; set; }

    public int? OrganisationId { get; set; }

    public int? OrganisationLevelId { get; set; }

    public int? UserId { get; set; }

    public int? JobPositionId { get; set; }

    public int? JobPositionGroupId { get; set; }

    public int? ContractTypeId { get; set; }

    public int? EmailRecepientTypeLkpId { get; set; }

    public bool IsInUserSelection { get; set; }

    public bool IsUserSelectionAnd { get; set; }

    public bool SelectChildOrganisations { get; set; }

    public bool SelectRecursiveChildOrganisations { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual AppLookupCode? EmailRecepientTypeLkp { get; set; }

    public virtual JobPosition? JobPosition { get; set; }

    public virtual JobPositionGroup? JobPositionGroup { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual OrganisationLevel? OrganisationLevel { get; set; }

    public virtual Subscription? Subscription { get; set; }

    public virtual ICollection<SubscriptionRuleUser> SubscriptionRuleUsers { get; set; } = new List<SubscriptionRuleUser>();

    public virtual User? User { get; set; }

    public virtual UserGroup? UserGroup { get; set; }
}
