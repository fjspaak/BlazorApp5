using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppViewDependency
{
    public int AppViewDependencyId { get; set; }

    public int ParentAppViewId { get; set; }

    public int ChildAppViewId { get; set; }

    public int? ParentAppDataObjectId { get; set; }

    public int? ChildAppDataObjectId { get; set; }

    public string? Path { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppView ChildAppView { get; set; } = null!;

    public virtual AppView ParentAppView { get; set; } = null!;
}
