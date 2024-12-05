using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DataSource
{
    public int DataSourceId { get; set; }

    public string? DataSourceName { get; set; }

    public string? Prompt { get; set; }

    public string? ConnectionString { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? Flags { get; set; }

    public int Version { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual ICollection<AppDataObject> AppDataObjects { get; set; } = new List<AppDataObject>();

    public virtual ICollection<Database> Databases { get; set; } = new List<Database>();
}
