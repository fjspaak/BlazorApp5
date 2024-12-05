using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwCustomerHierachy
{
    public int? CustomerId { get; set; }

    public int? CustomerLevelId { get; set; }

    public int? ParentCustomerId { get; set; }

    public int? L1Cid { get; set; }

    public int? L2Cid { get; set; }

    public int? L3Cid { get; set; }

    public int? L4Cid { get; set; }

    public int? L5Cid { get; set; }

    public int? L6Cid { get; set; }

    public int? L7Cid { get; set; }

    public int? L8Cid { get; set; }

    public int? RecursionId { get; set; }

    public string? CustomerCompleteId { get; set; }
}
