using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Login
{
    public int LoginId { get; set; }

    public int? UserId { get; set; }

    public int? DeviceTypeLkpId { get; set; }

    public string? UserName { get; set; }

    public string? IpAdress { get; set; }

    public string? ComputerName { get; set; }

    public DateTime? LoginDate { get; set; }

    public DateTime? LogoutDate { get; set; }

    public virtual AppLookupCode? DeviceTypeLkp { get; set; }

    public virtual ICollection<RequestLog> RequestLogs { get; set; } = new List<RequestLog>();

    public virtual User? User { get; set; }
}
