using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwAppDataObjectPageSelectAll
{
    public int ParentAppDataObjectId { get; set; }

    public string? ParentAppDataObjectName { get; set; }

    public int ChildAppDataObjectId { get; set; }

    public string? ChildAppDataObjectName { get; set; }

    public int AppDataObjectPageId { get; set; }

    public string? AppDataObjectPageName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? AppFormId { get; set; }

    public string? AppFormName { get; set; }

    public int? AppViewId { get; set; }

    public string? AppViewName { get; set; }

    public int? ParameterAppViewId { get; set; }

    public int? AppFormConfigId { get; set; }

    public string? AppFormConfigName { get; set; }

    public string? CodeReference { get; set; }

    public string? LinkedTable { get; set; }

    public bool AllowCopy { get; set; }

    public bool AllowPaste { get; set; }

    public bool IsInsertAllowed { get; set; }

    public bool IsUpdateAllowed { get; set; }

    public bool IsDeleteAllowed { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }
}
