using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Folder
{
    public int FolderId { get; set; }

    public int? ParentFolderId { get; set; }

    public int? AppFormId { get; set; }

    public int? AppViewId { get; set; }

    public int? OverviewId { get; set; }

    public int? AppFormConfigId { get; set; }

    public int? AppDataObjectId { get; set; }

    public int? FolderTypeLkpId { get; set; }

    public int? AppImageId { get; set; }

    public string? FolderName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public string? RowReference { get; set; }

    public string? CodeReference { get; set; }

    public string? GlobalReference { get; set; }

    public string? SortOrderCode { get; set; }

    public int? LevelId { get; set; }

    public string? FullPathFolderId { get; set; }

    public string? FullPathFolderName { get; set; }

    public string? FullPathSortOrderCode { get; set; }

    public bool IsSecInherited { get; set; }

    public bool IsSystem { get; set; }

    public bool IsHidden { get; set; }

    public bool OpenInNewWindow { get; set; }

    public bool IsReportClassification { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppDataObject? AppDataObject { get; set; }

    public virtual AppForm? AppForm { get; set; }

    public virtual AppFormConfig? AppFormConfig { get; set; }

    public virtual ICollection<AppFormConfig> AppFormConfigs { get; set; } = new List<AppFormConfig>();

    public virtual ICollection<AppFunction> AppFunctions { get; set; } = new List<AppFunction>();

    public virtual AppImage? AppImage { get; set; }

    public virtual ICollection<AppShortCut> AppShortCuts { get; set; } = new List<AppShortCut>();

    public virtual AppView? AppView { get; set; }

    public virtual AppLookupCode? FolderTypeLkp { get; set; }

    public virtual ICollection<FolderUser> FolderUsers { get; set; } = new List<FolderUser>();

    public virtual ICollection<Folder> InverseParentFolder { get; set; } = new List<Folder>();

    public virtual Overview? Overview { get; set; }

    public virtual ICollection<Overview> Overviews { get; set; } = new List<Overview>();

    public virtual Folder? ParentFolder { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
