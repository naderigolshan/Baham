using Microsoft.AspNetCore.Identity;

namespace Baham.Entities.Identity;

public class UserRole : IdentityUserRole<int>
{
    public virtual User User { get; set; }
    public virtual Role Role { get; set; }
}
