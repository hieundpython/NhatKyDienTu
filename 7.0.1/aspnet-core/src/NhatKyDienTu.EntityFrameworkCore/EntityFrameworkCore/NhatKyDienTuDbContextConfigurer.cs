using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NhatKyDienTu.EntityFrameworkCore
{
    public static class NhatKyDienTuDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NhatKyDienTuDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NhatKyDienTuDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
