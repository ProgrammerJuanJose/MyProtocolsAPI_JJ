using System;
using System.Collections.Generic;

namespace MyProtocolsAPI_JJ.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string BackUpEmail { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Address { get; set; }

    public bool? Active { get; set; }

    public bool? IsBlocked { get; set; }

    public int UserRoleId { get; set; }

    public virtual ICollection<ProtocolCategory> ProtocolCategories { get; set; } = new List<ProtocolCategory>();

    public virtual ICollection<ProtocolStep> ProtocolSteps { get; set; } = new List<ProtocolStep>();

    public virtual ICollection<Protocol> Protocols { get; set; } = new List<Protocol>();

    public virtual UserRole UserRole { get; set; } = null!;
}
