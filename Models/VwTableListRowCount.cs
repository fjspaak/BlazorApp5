using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwTableListRowCount
{
    public string TableName { get; set; } = null!;

    public string SchemaName { get; set; } = null!;

    public long? NrOfRecords { get; set; }

    public DateTime CreationDate { get; set; }
}
