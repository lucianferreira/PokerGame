namespace PokerGame.Entities
{
    using System.Data.Entity;

    public partial class PokerGameDB : DbContext
    {
        public PokerGameDB()
            : base("name=PokerGameDB")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
