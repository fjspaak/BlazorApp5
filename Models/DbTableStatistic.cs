using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DbTableStatistic
{
    public int DbTableStatisticsId { get; set; }

    public int DbTableId { get; set; }

    public int DateId { get; set; }

    public int? NrOfRows { get; set; }

    public int? NrOfNewRows { get; set; }

    public int? NrOfUpdatedRows { get; set; }

    public int? NrOfDeletedRows { get; set; }

    public string? Description { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual DbTable DbTable { get; set; } = null!;
}
