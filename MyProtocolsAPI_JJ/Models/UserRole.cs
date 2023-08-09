using System;
using System.Collections.Generic;

namespace MyProtocolsAPI_JJ.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
