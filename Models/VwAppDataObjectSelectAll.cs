using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwAppDataObjectSelectAll
{
    public int AppDataObjectId { get; set; }

    public string? AppDataObjectName { get; set; }

    public string? TableName { get; set; }

    public string? PrimaryFields { get; set; }

    public int? DataSourceId { get; set; }

    public string? DataSourceName { get; set; }

    public int? TitleAppViewId { get; set; }

    public string? TitleAppViewName { get; set; }

    public int? PageAppViewId { get; set; }

    public string? PageAppViewName { get; set; }

    public int? AppFormConfigId { get; set; }

    public string? AppFormConfigName { get; set; }

    public string? SearchFields { get; set; }

    public int AllowedSecurityId { get; set; }

    public bool IsInsertAllowed { get; set; }

    public bool IsUpdateAllowed { get; set; }

    public bool IsDeleteAllowed { get; set; }

    public bool IsSystem { get; set; }

    public bool IsEnabled { get; set; }

    public string? CodeReference { get; set; }

    public string? ExternalReference { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }
}
