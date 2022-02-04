using Abp.MultiTenancy;
using NhatKyDienTu.Authorization.Users;

namespace NhatKyDienTu.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
