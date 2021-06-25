namespace Git.Data
{
    using Git.Models;
    using Microsoft.EntityFrameworkCore;
  

    public class GitDbContext : DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Commit> Commits { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Git;Integrated Security=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Repository>()
                 .HasOne(r => r.Owner)
                 .WithMany(o => o.Repositories)
                 .HasForeignKey(r => r.OwnerId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Commit>()
                 .HasOne(r => r.Creator)
                 .WithMany(o => o.Commits)
                 .HasForeignKey(r => r.CreatorId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Commit>()
                .HasOne(r => r.Repository)
                .WithMany(o => o.Commits)
                .HasForeignKey(r => r.RepositoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
