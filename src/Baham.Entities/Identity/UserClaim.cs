using Microsoft.AspNetCore.Identity;

namespace Baham.Entities.Identity;

public class UserClaim : IdentityUserClaim<int>
{
    public virtual User User { get; set; }
}
