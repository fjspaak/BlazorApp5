using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class FolderUserIsRead
{
    public int FolderUserIsReadId { get; set; }

    public int FolderId { get; set; }

    public int UserId { get; set; }
}
