namespace MyBlog.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class MyBlogDbContextFactory
{
  private readonly string _connectionString;

  public MyBlogDbContextFactory( string connectionString )
  {
    _connectionString = connectionString;
  }
  
  public MyBlogDbContext Create()
  {
    var optionsBuilder = new DbContextOptionsBuilder<MyBlogDbContext>()
      .UseSqlite(_connectionString)
      .Options;

    return new MyBlogDbContext( optionsBuilder );
  }
}
