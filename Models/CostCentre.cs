using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class CostCentre
{
    public int CostCentreId { get; set; }

    public string? CostCentreCode { get; set; }

    public string? CostCentreName { get; set; }

    public bool IsClosed { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();
}
