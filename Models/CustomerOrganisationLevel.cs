using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class CustomerOrganisationLevel
{
    public int CustomerOrganisationLevelId { get; set; }

    public string? CustomerOrganisationLevelCode { get; set; }

    public string? CustomerOrganisationLevelName { get; set; }

    public string? Remarks { get; set; }

    public string? CodeReference { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<CustomerOrganisation1> CustomerOrganisation1s { get; set; } = new List<CustomerOrganisation1>();
}
