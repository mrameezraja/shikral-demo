using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shikral.Demo.Authorization.Roles;
using Shikral.Demo.Authorization.Users;
using Shikral.Demo.MultiTenancy;

namespace Shikral.Demo.EntityFrameworkCore
{
    public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }
    }
}
