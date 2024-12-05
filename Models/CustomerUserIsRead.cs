using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class CustomerUserIsRead
{
    public int CustomerUserIsReadId { get; set; }

    public int CustomerId { get; set; }

    public int UserId { get; set; }
}
