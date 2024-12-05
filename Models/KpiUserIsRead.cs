using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class KpiUserIsRead
{
    public int KpiUserIsReadId { get; set; }

    public int KpiId { get; set; }

    public int UserId { get; set; }
}
