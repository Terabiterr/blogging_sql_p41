using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Визначення зв'язку одним-багатьом між Blog і Post
        modelBuilder.Entity<Post>()
            .HasOne(p => p.Blog)
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BlogId)
            .OnDelete(DeleteBehavior.Cascade); // Опціонально, якщо хочете автоматичне видалення постів під час видалення блогу

        // Визначення первинного ключа для BlogId та PostId
        modelBuilder.Entity<Blog>().HasKey(b => b.BlogId);
        modelBuilder.Entity<Post>().HasKey(p => p.PostId);

        // Опціонально, якщо ви хочете змінити імена таблиць у базі даних
        modelBuilder.Entity<Blog>().ToTable("Blogs");
        modelBuilder.Entity<Post>().ToTable("Posts");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DOMBROVSKY;Database=Blogging;Integrated Security=True;TrustServerCertificate=True");
    }
}
