using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwBrDbTableFieldNotExistInDb
{
    public int DbTableId { get; set; }

    public string? DbTableName { get; set; }

    public string? FieldName { get; set; }

    public string? Remarks { get; set; }

    public int? DataTypeLkpId { get; set; }
}
