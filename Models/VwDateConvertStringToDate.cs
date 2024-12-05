using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwDateConvertStringToDate
{
    public string DateString { get; set; } = null!;

    public DateTime? StrToDateValue { get; set; }

    public DateTime? CastToDateValue { get; set; }

    public int? DaysDiff { get; set; }
}
