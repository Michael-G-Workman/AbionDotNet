using AbionDotNet.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AbionDotNet.DAL
{
    public class AbionDotNetContext : DbContext
    {
        public AbionDotNetContext() : base("AbionDotNetContext")
        {
        }

        public DbSet<ContactCategory> ContactCategories { get; set; }
        public DbSet<EmailContact> EmailContacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}