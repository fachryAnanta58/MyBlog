using System.Text.RegularExpressions;

namespace MyBlog.Application.Services;

using Domain.Interfaces;
using Domain.Models;

public class PostService(IPostRepository postRepository, IProfileRepository profileRepository)
{
  public async Task<IEnumerable<Post>> GetAllPostsAsync()
  {
    return await postRepository.GetAllAsync();
  }

  public async Task CreatePostAsync( Post post )
  {
    var html = post.Content;
    // replace ../uploads/ with /uploads/
    html = Regex.Replace(html, @"(\.\.\/uploads\/)", "/uploads/");
    post.Content = html;
    await postRepository.AddAsync( post );
  }

  public async Task<Post?> GetPostByIdAsync(int id)
  {
    return await postRepository.GetByIdAsync(id);
  }

  public async Task DeletePostAsync(int id)
  {
    await postRepository.DeleteAsync(id);
  }
}
