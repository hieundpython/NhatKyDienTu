using Abp.Authorization;
using NhatKyDienTu.Authorization.Roles;
using NhatKyDienTu.Authorization.Users;

namespace NhatKyDienTu.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
