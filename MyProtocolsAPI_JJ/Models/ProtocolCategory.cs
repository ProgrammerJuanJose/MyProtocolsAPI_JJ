using System;
using System.Collections.Generic;

namespace MyProtocolsAPI_JJ.Models;

public partial class ProtocolCategory
{
    public int ProtocolCategory1 { get; set; }

    public string Description { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<Protocol> Protocols { get; set; } = new List<Protocol>();

    public virtual User User { get; set; } = null!;
}
