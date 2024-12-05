using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class FolderUser
{
    public int FolderUserId { get; set; }

    public int UserId { get; set; }

    public int FolderId { get; set; }

    public int SecurityId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsCustom { get; set; }

    public virtual Folder Folder { get; set; } = null!;

    public virtual Security Security { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
