using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DbTableFieldStatistic
{
    public int DbTableFieldStatisticsId { get; set; }

    public int DbTableFieldId { get; set; }

    public int DateId { get; set; }

    public int? NrOfUniqueValues { get; set; }

    public int? NrOfNullValues { get; set; }

    public string? MaxValue { get; set; }

    public string? MinValue { get; set; }

    public string? AvgValue { get; set; }

    public string? Description { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual DbTableField DbTableField { get; set; } = null!;
}
