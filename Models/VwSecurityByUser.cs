using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityByUser
{
    public int UserId { get; set; }

    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public string? ContractTypeCode { get; set; }

    public string? ContractType { get; set; }

    public string? FunctieCode { get; set; }

    public string? Functie { get; set; }

    public string? FunctieGroep { get; set; }

    public string OrganisatieLevel { get; set; } = null!;

    public string KlantLevel { get; set; } = null!;
}
