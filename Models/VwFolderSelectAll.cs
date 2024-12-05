using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwFolderSelectAll
{
    public int FolderId { get; set; }

    public string? FullPathFolderName { get; set; }

    public string? FolderName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? ParentFolderId { get; set; }

    public string? ParentFolderName { get; set; }

    public int? AppFormId { get; set; }

    public string? AppFormName { get; set; }

    public int? AppViewId { get; set; }

    public string? AppViewName { get; set; }

    public int? AppFormConfigId { get; set; }

    public string? AppFormConfigName { get; set; }

    public int? AppDataObjectId { get; set; }

    public string? AppDataObjectName { get; set; }

    public int? FolderTypeLkpId { get; set; }

    public string? FolderTypeLkpName { get; set; }

    public string? RowReference { get; set; }

    public string? CodeReference { get; set; }

    public string? SortOrderCode { get; set; }

    public int? LevelId { get; set; }

    public string? FullPathFolderId { get; set; }

    public string? FullPathSortOrderCode { get; set; }

    public int? AppImageId { get; set; }

    public string? AppImageName { get; set; }

    public bool IsSecInherited { get; set; }

    public bool IsSystem { get; set; }

    public bool IsHidden { get; set; }

    public bool OpenInNewWindow { get; set; }

    public bool IsReportClassification { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }
}
