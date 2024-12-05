using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppShortCut
{
    public int AppShortCutId { get; set; }

    public int? UserId { get; set; }

    public int? FolderId { get; set; }

    public int? AppFormConfigId { get; set; }

    public int? AppImageId { get; set; }

    public int? AppDataObjectId { get; set; }

    public string? AppShortCutName { get; set; }

    public int? PositionX { get; set; }

    public int? PositionY { get; set; }

    public string? RowReference { get; set; }

    public string? CodeReference { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppFormConfig? AppFormConfig { get; set; }

    public virtual AppImage? AppImage { get; set; }

    public virtual ICollection<AppRowReference> AppRowReferences { get; set; } = new List<AppRowReference>();

    public virtual Folder? Folder { get; set; }

    public virtual User? User { get; set; }
}
