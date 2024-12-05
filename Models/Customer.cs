using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public int? CustomerLevelId { get; set; }

    public int? ParentCustomerId { get; set; }

    public int? CustomerOrganisationId { get; set; }

    public int? AccountManagerUserId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public bool IsInternalCustomer { get; set; }

    public string? CompleteCustomerId { get; set; }

    public string? CompleteCustomerCode { get; set; }

    public string? CompleteCustomerName { get; set; }

    public string? Remarks { get; set; }

    public int? ExternalReference { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public int? L1Cid { get; set; }

    public int? L2Cid { get; set; }

    public int? L3Cid { get; set; }

    public int? L4Cid { get; set; }

    public int? L5Cid { get; set; }

    public int? L6Cid { get; set; }

    public int? L7Cid { get; set; }

    public int? L8Cid { get; set; }

    public string? CompleteCid { get; set; }

    public string? GlobalReference { get; set; }

    public virtual CustomerLevel? CustomerLevel { get; set; }

    public virtual CustomerOrganisation1? CustomerOrganisation { get; set; }

    public virtual ICollection<CustomerOrganisation1> CustomerOrganisation1s { get; set; } = new List<CustomerOrganisation1>();

    public virtual ICollection<CustomerUser> CustomerUsers { get; set; } = new List<CustomerUser>();

    public virtual ICollection<Customer> InverseParentCustomer { get; set; } = new List<Customer>();

    public virtual Customer? ParentCustomer { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();
}
