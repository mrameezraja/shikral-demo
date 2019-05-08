using Abp.Authorization;
using Shikral.Demo.Authorization.Roles;
using Shikral.Demo.Authorization.Users;

namespace Shikral.Demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
