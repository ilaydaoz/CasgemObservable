using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CasgemObservable.Dal
{
    public class Context :  IdentityDbContext<AppUser ,AppRole, int >
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AKOHCIC\\SQLEXPRESS;initial catalog=CasgemObservable;integrated Security=true");
        }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProceses { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
    }
}
