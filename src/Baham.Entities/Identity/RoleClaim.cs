using Microsoft.AspNetCore.Identity;

namespace Baham.Entities.Identity;

public class RoleClaim : IdentityRoleClaim<int>
{
    public virtual Role Role { get; set; }
}
