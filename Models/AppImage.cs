using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppImage
{
    public int AppImageId { get; set; }

    public int? AppImageTypeLkpId { get; set; }

    public string AppImageName { get; set; } = null!;

    public string? AppImageFileAddress { get; set; }

    public byte[]? AppImageObject { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? CodeReference { get; set; }

    public string? Remarks { get; set; }

    public bool IsSystem { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual ICollection<AppDataObjectPage> AppDataObjectPages { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppDataObject> AppDataObjects { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppFunction> AppFunctions { get; set; } = new List<AppFunction>();

    public virtual AppLookupCode? AppImageTypeLkp { get; set; }

    public virtual ICollection<AppShortCut> AppShortCuts { get; set; } = new List<AppShortCut>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<SystemSetting> SystemSettings { get; set; } = new List<SystemSetting>();
}
