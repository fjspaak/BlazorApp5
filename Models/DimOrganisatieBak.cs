using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DimOrganisatieBak
{
    public long OrganisatieId { get; set; }

    public string? OrganisatieCode { get; set; }

    public string? OrganisatieNaam { get; set; }

    public string? VolledigeOrganisatieId { get; set; }

    public string? VolledigeOrganisatieCode { get; set; }

    public string? VolledigeOrganisatieNaam { get; set; }

    public long? ParentOrganisatieId { get; set; }

    public int? LevelId { get; set; }

    public string? LevelCode { get; set; }

    public int? ZoneId { get; set; }

    public string? ZoneCode { get; set; }

    public int? AreaId { get; set; }

    public string? AreaCode { get; set; }

    public int? BranchId { get; set; }

    public string? BranchCode { get; set; }

    public int? KostenPlaatsId { get; set; }

    public string? KostenPlaatsCode { get; set; }

    public string? KostenPlaatsNaam { get; set; }

    public DateTime MetaCreatieDatum { get; set; }

    public DateTime MetaMutatieDatum { get; set; }

    public string MetaProcesId { get; set; } = null!;

    public bool MetaIsActueel { get; set; }

    public bool MetaIsOngeldig { get; set; }

    public int MetaVersieId { get; set; }

    public DateTime MetaBeginDatum { get; set; }

    public DateTime MetaEindDatum { get; set; }

    public string MetaHashType0 { get; set; } = null!;
}
