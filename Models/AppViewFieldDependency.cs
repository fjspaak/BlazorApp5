using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppViewFieldDependency
{
    public int AppViewFieldDependencyId { get; set; }

    public int? ParentAppViewFieldId { get; set; }

    public int? ChildAppViewFieldId { get; set; }

    public string? SortOrderCode { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual AppViewField? ChildAppViewField { get; set; }

    public virtual AppViewField? ParentAppViewField { get; set; }
}
