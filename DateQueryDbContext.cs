using System.Data.Entity;

namespace EntityFrameworkDateQuery
{
    public class DateQueryDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateQueryDbContext" /> class.
        /// </summary>
        public DateQueryDbContext() : base(nameOrConnectionString: "Data Source=localhost;Initial Catalog=DateQuery;Integrated Security=true;")
        {
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>The users.</value>
        public DbSet<User> Users { get; set; }
    }
}