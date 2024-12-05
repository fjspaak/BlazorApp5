using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class CustomerLevel
{
    public int CustomerLevelId { get; set; }

    public string? CustomerLevelCode { get; set; }

    public string? CustomerLevelName { get; set; }

    public string? CodeReference { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<User> UserCustomCustomerLevels { get; set; } = new List<User>();

    public virtual ICollection<User> UserDefaultCustomerLevels { get; set; } = new List<User>();
}
