using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class UserStatistic
{
    public int UserStatisticsId { get; set; }

    public int UserId { get; set; }

    public int DateId { get; set; }

    public int? NrOfOrgAllocations { get; set; }

    public int? NrOfOrgCustomAllocations { get; set; }

    public int? NrOfOrgDefaultAllocations { get; set; }

    public int? NrOfOrgRulesAllocations { get; set; }

    public string? OrgCustomAllocations { get; set; }

    public string? OrgDefaultAllocations { get; set; }

    public bool IsReadyToBeDeleted { get; set; }

    public bool IsEqualToPreviousRow { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual User User { get; set; } = null!;
}
