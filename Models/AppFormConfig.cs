using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppFormConfig
{
    public int AppFormConfigId { get; set; }

    public int? RandomId { get; set; }

    public int? AppDataObjectId { get; set; }

    public int? AppFormId { get; set; }

    public int? AppViewId { get; set; }

    public int? FolderId { get; set; }

    public int? UserId { get; set; }

    public string? AppFormConfigName { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool MasterIsListVisible { get; set; }

    public bool MasterIsListVisibilityChangeable { get; set; }

    public bool MasterIsOverviewSelectionVisible { get; set; }

    public int? MasterListWidth { get; set; }

    public int? MasterListHeight { get; set; }

    public bool MasterIsHorizontalListVsHub { get; set; }

    public bool MasterIsHorizontalHubs { get; set; }

    public bool MasterHub1IsVisible { get; set; }

    public bool MasterHub1IsVisibilityChangeable { get; set; }

    public int? MasterHub1Width { get; set; }

    public int? MasterHub1Height { get; set; }

    public int? MasterHub1PageLayoutTypeLkpId { get; set; }

    public bool MasterHub2IsVisible { get; set; }

    public bool MasterHub2IsVisibilityChangeable { get; set; }

    public int? MasterHub2Width { get; set; }

    public int? MasterHub2Height { get; set; }

    public int? MasterHub2PageLayoutTypeLkpId { get; set; }

    public int? Hub1AppDataObjectPageId { get; set; }

    public bool Hub1IsPagesVisible { get; set; }

    public bool Hub1IsPagesVisibilityChangeable { get; set; }

    public bool Hub1IsHorizontal { get; set; }

    public bool Hub1Detail1IsVisible { get; set; }

    public bool Hub1Detail1IsVisibilityChangeable { get; set; }

    public int? Hub1Detail1Width { get; set; }

    public int? Hub1Detail1Height { get; set; }

    public int? Hub1Detail1AppDataObjectPageId { get; set; }

    public int? Hub1Detail1AppActionId { get; set; }

    public bool Hub1Detail2IsVisible { get; set; }

    public bool Hub1Detail2IsVisibilityChangeable { get; set; }

    public int? Hub1Detail2Width { get; set; }

    public int? Hub1Detail2Height { get; set; }

    public int? Hub1Detail2AppDataObjectPageId { get; set; }

    public int? Hub1Detail2AppActionId { get; set; }

    public int? Hub2AppDataObjectPageId { get; set; }

    public bool Hub2IsPagesVisible { get; set; }

    public bool Hub2IsPagesVisibilityChangeable { get; set; }

    public bool Hub2IsHorizontal { get; set; }

    public bool Hub2Detail1IsVisible { get; set; }

    public bool Hub2Detail1IsVisibilityChangeable { get; set; }

    public int? Hub2Detail1Width { get; set; }

    public int? Hub2Detail1Height { get; set; }

    public int? Hub2Detail1AppDataObjectPageId { get; set; }

    public int? Hub2Detail1AppActionId { get; set; }

    public bool Hub2Detail2IsVisible { get; set; }

    public bool Hub2Detail2IsVisibilityChangeable { get; set; }

    public int? Hub2Detail2Width { get; set; }

    public int? Hub2Detail2Height { get; set; }

    public int? Hub2Detail2AppDataObjectPageId { get; set; }

    public int? Hub2Detail2AppActionId { get; set; }

    public bool ReportResultShowParameters { get; set; }

    public bool OpenOnlyOnce { get; set; }

    public bool IsReadyForDelete { get; set; }

    public string? CodeReference { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppDataObjectPage> AppDataObjectPages { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppDataObject> AppDataObjects { get; set; } = new List<AppDataObject>();

    public virtual AppForm? AppForm { get; set; }

    public virtual ICollection<AppRowReference> AppRowReferences { get; set; } = new List<AppRowReference>();

    public virtual ICollection<AppShortCut> AppShortCuts { get; set; } = new List<AppShortCut>();

    public virtual Folder? Folder { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual AppLookupCode? MasterHub1PageLayoutTypeLkp { get; set; }

    public virtual AppLookupCode? MasterHub2PageLayoutTypeLkp { get; set; }

    public virtual User? User { get; set; }
}
