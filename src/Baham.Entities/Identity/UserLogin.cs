using Microsoft.AspNetCore.Identity;

namespace Baham.Entities.Identity;

public class UserLogin : IdentityUserLogin<int>
{
    public virtual User User { get; set; }
}
