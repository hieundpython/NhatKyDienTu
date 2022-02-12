using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NhatKyDienTu.Authorization.Roles;
using NhatKyDienTu.Authorization.Users;
using NhatKyDienTu.MultiTenancy;
using NhatKyDienTu.MainModel.ThongTinChung;
using NhatKyDienTu.MainModel.NhatKy;

namespace NhatKyDienTu.EntityFrameworkCore
{
    public class NhatKyDienTuDbContext : AbpZeroDbContext<Tenant, Role, User, NhatKyDienTuDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ThongTinChung> ThongTinChungs { get; set; }

        public DbSet<NhatKy> NhatKys { get; set; }

        public NhatKyDienTuDbContext(DbContextOptions<NhatKyDienTuDbContext> options)
            : base(options)
        {
        }
    }
}
