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
    await postRepository.AddAsync( post );
  }

  public async Task<Post?> GetPostByIdAsync(int id)
  {
    return await postRepository.GetByIdAsync(id);
  }
}
