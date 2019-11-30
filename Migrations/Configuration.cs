using System.Data.Entity.Migrations;

namespace EntityFrameworkDateQuery.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkDateQuery.DateQueryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkDateQuery.DateQueryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}