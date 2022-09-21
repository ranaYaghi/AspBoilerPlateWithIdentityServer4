using Abp.Authorization;
using IdentityServer.Authorization.Roles;
using IdentityServer.Authorization.Users;

namespace IdentityServer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
