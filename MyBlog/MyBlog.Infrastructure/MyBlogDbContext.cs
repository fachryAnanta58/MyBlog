namespace MyBlog.Infrastructure;

using Domain.Models;
using Microsoft.EntityFrameworkCore;

public class MyBlogDbContext : DbContext
{
  private readonly string _connectionString;

  public MyBlogDbContext()
  {
    _connectionString = "Data Source=MyBlog.db";
  }
  public MyBlogDbContext( string connectionString )
  {
    _connectionString = connectionString;
  }
  
  public override int SaveChanges()
  {
    var entries = ChangeTracker.Entries().Where( e => e is { Entity: ModelBase, State: EntityState.Modified } );
    foreach( var entityEntry in entries )
    {
      ( (ModelBase)entityEntry.Entity ).Updated = DateTime.Now;
    }

    return base.SaveChanges();
  }
  
  protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
  {
    optionsBuilder.UseSqlite( _connectionString );
  }
  
  protected override void OnModelCreating( ModelBuilder modelBuilder )
  {
    modelBuilder.Entity<Post>().ToTable( "Posts" );
    modelBuilder.Entity<Profile>().ToTable( "Profiles" );
    modelBuilder.Entity<Experience>().ToTable( "Experiences" );
    modelBuilder.Entity<Project>().ToTable( "Projects" );
    
    modelBuilder.Entity<Profile>()
      .HasMany( p => p.Experiences )
      .WithOne( e => e.Profile)
      .HasForeignKey( e => e.ProfileId );
    modelBuilder.Entity<Profile>()
      .HasMany( p => p.Projects )
      .WithOne( p => p.Profile )
      .HasForeignKey( p => p.ProfileId );
    modelBuilder.Entity<Profile>()
      .HasMany( p => p.Posts )
      .WithOne( p => p.Profile )
      .HasForeignKey( p => p.ProfileId );

    Seed( modelBuilder );
  }

  private void Seed( ModelBuilder modelBuilder )
  {
    var experience = new Experience
    {
      Id = -1,
      Title = "Software Engineer",
      Company = "My Company",
      Location = "Jakarta, Indonesia",
      Description = "Developing software",
      StartDate = new DateTime( 2021, 1, 1 ),
      Tags = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core" },
      ProfileId = -1
    };
    
    var project = new Project
    {
      Id = -1,
      Name = "My Project",
      Description = "Developing a project",
      ImageUrl = "project.jpg",
      GitHubUrl = "https://github.com",
      DemoUrl = "https://demo.com",
      Tags = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core" },
      Technologies = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core" },
      Features = new List<string> { "Feature 1", "Feature 2", "Feature 3" },
      Screenshots = new List<string> { "screenshot1.jpg", "screenshot2.jpg", "screenshot3.jpg" },
      ProfileId = -1
    };

    var profile = new Profile
    {
      Id = -1,
      Name = "Fachry Ananta",
      Bio = "Software Engineer",
      ProfilePicture = "profile.jpg",
      Email = "fachry.ananta18@gmail.com",
      PhoneNumber = "081234567890",
      Skills = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core" }
    };

    var posts = new List<Post>
    {
      new()
      {
        Id = -1,
        Title = "My First Post",
        Subtitle = "This is my first post",
        Content = "This is my first seed post",
        ProfileId = -1
      },
      new()
      {
        Id = -2,
        Title = "My Second Post",
        Subtitle = "This is my second post",
        Content = "This is my second seed post",
        ProfileId = -1
      }
    };
    
    modelBuilder.Entity<Profile>().HasData( profile );
    modelBuilder.Entity<Experience>().HasData( experience );
    modelBuilder.Entity<Project>().HasData( project );
    modelBuilder.Entity<Post>().HasData( posts );
  }
  
  public DbSet<Post> Posts { get; set; }
  public DbSet<Profile> Profiles { get; set; }
  public DbSet<Experience> Experiences { get; set; }
  public DbSet<Project> Projects { get; set; }
}
