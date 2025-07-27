namespace Progress.models
{
    public class ProgressContext : DbContext
    {
        public ProgressContext(DbContextOptions<ProgressContext> options) : base (options)
        { 
        }

        public DbSet<Item> item { get; set; } = null;
    }
}
