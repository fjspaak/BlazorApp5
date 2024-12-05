﻿using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Sysssislog
{
    public int Id { get; set; }

    public string Event { get; set; } = null!;

    public string Computer { get; set; } = null!;

    public string Operator { get; set; } = null!;

    public string Source { get; set; } = null!;

    public Guid Sourceid { get; set; }

    public Guid Executionid { get; set; }

    public DateTime Starttime { get; set; }

    public DateTime Endtime { get; set; }

    public int Datacode { get; set; }

    public byte[]? Databytes { get; set; }

    public string Message { get; set; } = null!;
}
