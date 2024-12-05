using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppViewStatistic
{
    public int AppViewStatisticsId { get; set; }

    public int AppViewId { get; set; }

    public int DateId { get; set; }

    public int? NrOfExceptions { get; set; }

    public int? NrOfRows { get; set; }

    public string? Description { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppView AppView { get; set; } = null!;
}
