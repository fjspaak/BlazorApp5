using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Database
{
    public int DatabaseId { get; set; }

    public int? DataSourceId { get; set; }

    public string? DatabaseName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? ObjectId { get; set; }

    public string? ExternalReference { get; set; }

    public string? GlobalReference { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual DataSource? DataSource { get; set; }

    public virtual ICollection<DbTable> DbTables { get; set; } = new List<DbTable>();
}
