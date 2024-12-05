using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSubscriptionUserAllocation
{
    public int? SubscriptionId { get; set; }

    public string? SubscriptionName { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? ContractTypeName { get; set; }

    public string? JobPositionName { get; set; }

    public string? JobPositionGroupName { get; set; }

    public int AllOrganisations { get; set; }

    public string? HighestOrgLevelName { get; set; }

    public string? OrgCustomAllocations { get; set; }

    public string? OrgDefaultAllocations { get; set; }

    public string? DefaultOrganisation { get; set; }

    public int? DefaultOrganisationLevelId { get; set; }

    public string? DefaultOrganisationLevelCode { get; set; }

    public string? DefaultOrganisationLevelName { get; set; }

    public string? DefaultOrganisationReference { get; set; }

    public int? NrOfOrgAllocationsAll { get; set; }

    public int? NrOfOrgAllocationsCustom { get; set; }

    public int? NrOfOrgAllocationsDefault { get; set; }

    public int? NrOfOrgAllocationsRules { get; set; }

    public int? InR { get; set; }

    public int? InCr { get; set; }

    public int? InBc { get; set; }

    public bool IsUserProfile { get; set; }

    public bool IsVirtualUser { get; set; }

    public bool IsSystem { get; set; }
}
