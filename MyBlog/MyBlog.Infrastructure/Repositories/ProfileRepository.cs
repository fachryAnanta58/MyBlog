using Microsoft.EntityFrameworkCore;
using MyBlog.Domain.Interfaces;
using MyBlog.Domain.Models;

namespace MyBlog.Infrastructure.Repositories;

public class ProfileRepository(MyBlogDbContextFactory contextFactory) : IProfileRepository
{
  public async Task<Profile?> GetByUserId(int userId)
  {
    await using var context = contextFactory.Create();

    return await context.Profiles.FirstOrDefaultAsync(p => p.Id == userId);
  }
}