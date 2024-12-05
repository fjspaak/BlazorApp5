using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class CustomerOrganisation1
{
    public int CustomerOrganisationId { get; set; }

    public int? ParentCustomerOrganisationId { get; set; }

    public int? RootCustomerId { get; set; }

    public int? CustomerOrganisationLevelId { get; set; }

    public string? CustomerOrganisationCode { get; set; }

    public string? CustomerOrganisationName { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual CustomerOrganisationLevel? CustomerOrganisationLevel { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<CustomerOrganisation1> InverseParentCustomerOrganisation { get; set; } = new List<CustomerOrganisation1>();

    public virtual CustomerOrganisation1? ParentCustomerOrganisation { get; set; }

    public virtual Customer? RootCustomer { get; set; }
}
