using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppRowReference
{
    public int AppRowReferenceId { get; set; }

    public int? AppFormConfigId { get; set; }

    public int? AppDataObjectId { get; set; }

    public int? AppShortCutId { get; set; }

    public string? RowReference { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual AppDataObject? AppDataObject { get; set; }

    public virtual AppFormConfig? AppFormConfig { get; set; }

    public virtual AppShortCut? AppShortCut { get; set; }
}
