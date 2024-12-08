using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace MyBlog.Application.Services;

using Domain.Interfaces;
using Domain.Models;

public class PostService(IPostRepository postRepository, IProfileRepository profileRepository)
{
  public async Task<IEnumerable<Post>> GetAllPostsAsync()
  {
    var posts = await postRepository.GetAllAsync();

    return posts.OrderByDescending(p => p.Created);
  }

  public async Task CreatePostAsync( Post post )
  {
    post.Content = ReplaceImgSrc(post.Content, out var firstImgSrc);
    post.ImagePreview = firstImgSrc;

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

  public async Task UpdatePostAsync(Post post)
  {
    ReplaceImgSrc(post.Content, out var firstImgSrc);
    post.ImagePreview = firstImgSrc;
    
    await postRepository.UpdateAsync(post);
  }

  private string ReplaceImgSrc(string html, out string? firstImgSrc)
  {
    firstImgSrc = null;
    var htmlDoc = new HtmlDocument();
    htmlDoc.LoadHtml(html);

    var imgNodes = htmlDoc.DocumentNode.SelectNodes("//img");
    if (imgNodes == null)
    {
      return html;
    }

    foreach (var imgNode in imgNodes)
    {
      var imgSrc = imgNode.GetAttributeValue("src", "");
      imgSrc = imgSrc.Replace("../uploads/", "/uploads/");
      imgNode.SetAttributeValue("src", imgSrc);
    }

    firstImgSrc = imgNodes.FirstOrDefault()?.GetAttributeValue("src", "");

    return htmlDoc.DocumentNode.OuterHtml;
  }
}
