using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwAppDataObjectUserAdmin
{
    public int AppDataObjectUserId { get; set; }

    public int AppDataObjectId { get; set; }

    public int UserId { get; set; }

    public int SecurityId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsCustom { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }
}
