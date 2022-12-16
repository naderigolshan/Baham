using Baham.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Baham.Entities;

public class Role : IdentityRole<int>
{
    public Role(string name) : base(name)
    {
    }
    public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }

}
