using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class ContractType
{
    public int ContractTypeId { get; set; }

    public string? ContractTypeCode { get; set; }

    public string? ContractTypeName { get; set; }

    public string? Remarks { get; set; }

    public string? CodeReference { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public string? GlobalReference { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
