using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Organisation
{
    public int OrganisationId { get; set; }

    public int? OrganisationLevelId { get; set; }

    public int? ParentOrganisationId { get; set; }

    public int? CostCentreId { get; set; }

    public int? ManagerUserId { get; set; }

    public string? OrganisationCode { get; set; }

    public string? OrganisationName { get; set; }

    public string? BusinessPhone { get; set; }

    public string? CompleteOrganisationId { get; set; }

    public string? CompleteOrganisationCode { get; set; }

    public string? CompleteOrganisationName { get; set; }

    public string? ExternalReference { get; set; }

    public bool IsSelectable { get; set; }

    public int? L1Oid { get; set; }

    public int? L2Oid { get; set; }

    public int? L3Oid { get; set; }

    public int? L4Oid { get; set; }

    public int? L5Oid { get; set; }

    public int? L6Oid { get; set; }

    public int? L7Oid { get; set; }

    public int? L8Oid { get; set; }

    public string? CompleteOid { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public string? GlobalReference { get; set; }

    public virtual CostCentre? CostCentre { get; set; }

    public virtual ICollection<Organisation> InverseParentOrganisation { get; set; } = new List<Organisation>();

    public virtual User? ManagerUser { get; set; }

    public virtual OrganisationLevel? OrganisationLevel { get; set; }

    public virtual ICollection<OrganisationUser> OrganisationUsers { get; set; } = new List<OrganisationUser>();

    public virtual Organisation? ParentOrganisation { get; set; }

    public virtual ICollection<SecurityRule> SecurityRuleOrganisations { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SecurityRule> SecurityRuleSecuredOrganisations { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
