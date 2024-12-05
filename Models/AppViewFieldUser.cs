using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppViewFieldUser
{
    public int AppViewFieldUserId { get; set; }

    public int AppViewFieldId { get; set; }

    public int UserId { get; set; }

    public string? DefaultValueRefName { get; set; }

    public string? DefaultValue { get; set; }

    public int? RowHeigth { get; set; }

    public int? ColumnWidth { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual AppViewField AppViewField { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
