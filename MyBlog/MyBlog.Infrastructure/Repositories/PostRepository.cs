namespace MyBlog.Infrastructure.Repositories;

using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

public class PostRepository(MyBlogDbContextFactory contextFactory) : IPostRepository
{
  public async Task<IEnumerable<Post>> GetAllAsync()
  {
    await using var context = contextFactory.Create();
    
    return await context.Posts.ToListAsync();
  }

  public async Task<Post?> GetByIdAsync(int id)
  {
    await using var context = contextFactory.Create();

    return await context.Posts.FindAsync(id);
  }

  public async Task AddAsync(Post post)
  {
    post.ProfileId = -1;
    await using var context = contextFactory.Create();

    context.Posts.Add(post);
    await context.SaveChangesAsync();
  }

  public async Task DeleteAsync(int id)
  {
    await using var context = contextFactory.Create();

    var post = await context.Posts.FindAsync(id);
    if (post == null)
    {
      return;
    }

    context.Posts.Remove(post);
    await context.SaveChangesAsync();
  }
}
