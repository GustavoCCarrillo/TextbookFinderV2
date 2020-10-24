using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TextbookFinder.Models
{
    public partial class TextbooksDBContext : DbContext
    {
        public TextbooksDBContext()
        {
        }

        public TextbooksDBContext(DbContextOptions<TextbooksDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<TextbookAuthors> TextbookAuthors { get; set; }
        public virtual DbSet<TextbookCategories> TextbookCategories { get; set; }
        public virtual DbSet<TextbookPublishers> TextbookPublishers { get; set; }
        public virtual DbSet<Textbooks> Textbooks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MyNovo;Database=TextbooksDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.Property(e => e.AuthorId).HasColumnName("Author_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.Categories)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TextbookAuthors>(entity =>
            {
                entity.HasKey(e => new { e.TextbookId, e.AuthorId });

                entity.ToTable("Textbook_Authors");

                entity.Property(e => e.TextbookId).HasColumnName("Textbook_id");

                entity.Property(e => e.AuthorId).HasColumnName("Author_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TextbookAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Author_id");

                entity.HasOne(d => d.Textbook)
                    .WithMany(p => p.TextbookAuthors)
                    .HasForeignKey(d => d.TextbookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Texbooks");
            });

            modelBuilder.Entity<TextbookCategories>(entity =>
            {
                entity.HasKey(e => new { e.TextbookId, e.CategoryId });

                entity.ToTable("Textbook_Categories");

                entity.Property(e => e.TextbookId).HasColumnName("Textbook_id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TextbookCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories");

                entity.HasOne(d => d.Textbook)
                    .WithMany(p => p.TextbookCategories)
                    .HasForeignKey(d => d.TextbookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Texbooks_Categories");
            });

            modelBuilder.Entity<TextbookPublishers>(entity =>
            {
                entity.HasKey(e => e.PublisherId);

                entity.ToTable("Textbook_Publishers");

                entity.Property(e => e.PublisherId).HasColumnName("Publisher_id");

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasColumnName("Publisher_name")
                    .HasMaxLength(200);

                entity.Property(e => e.PublisherWebsite).HasColumnName("Publisher_website");
            });

            modelBuilder.Entity<Textbooks>(entity =>
            {
                entity.HasKey(e => e.TextbookId);

                entity.Property(e => e.TextbookId).HasColumnName("Textbook_id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.Edition).HasMaxLength(5);

                entity.Property(e => e.Isbn).HasMaxLength(50);

                entity.Property(e => e.PublishedDate)
                    .HasColumnName("Published_date")
                    .HasColumnType("date");

                entity.Property(e => e.PublisherId).HasColumnName("Publisher_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Textbooks)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Category");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Textbooks)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_Texbook_Publisher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
