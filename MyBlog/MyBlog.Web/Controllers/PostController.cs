using MyBlog.Domain.Models;

namespace MyBlog.Controllers;

using Application.Services;
using Microsoft.AspNetCore.Mvc;

public class PostController( PostService postService ) : Controller
{
  [HttpGet]
  public async Task<IActionResult> Index()
  {
    var posts = await postService.GetAllPostsAsync();

    return View( posts );
  }

  [HttpGet]
  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public async Task<IActionResult> Create(Post post)
  {
    await postService.CreatePostAsync(post);
    return RedirectToAction(nameof(Index));
  }

  [HttpGet]
  public async Task<IActionResult> Details(int id)
  {
    var post = await postService.GetPostByIdAsync(id);
    if (post == null)
    {
      return NotFound();
    }
    return View(post);
  }
}
