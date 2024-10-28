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

  [HttpPost]
  public async Task<IActionResult> Delete(int id)
  {
    var post = await postService.GetPostByIdAsync(id);
    if (post == null)
    {
      return NotFound();
    }
    await postService.DeletePostAsync(id);

    return RedirectToAction(nameof(Index));
  }

  [HttpPost]
  public IActionResult UploadImage(IFormFile file)
  {
    if (file.Length <= 0)
      return BadRequest();

    if (!Directory.Exists("wwwroot/uploads"))
    {
      Directory.CreateDirectory("wwwroot/uploads");
    }

    var date = DateTime.Now.ToString("yyyyMMddHHmmss");
    var filePath = Path.Combine("wwwroot/uploads", $"{date}_{file.FileName}");
    var fileName = Path.GetFileName(filePath);

    using (var stream = new FileStream(filePath, FileMode.Create))
    {
      file.CopyTo(stream);
    }

    var imageUrl = Url.Content($"~/uploads/{fileName}");
    return Json(new { location = imageUrl });
  }

  [HttpGet]
  public async Task<IActionResult> Edit(int id)
  {
    var post = await postService.GetPostByIdAsync(id);
    if (post == null)
    {
      return NotFound();
    }

    return View(post);
  }

  [HttpPost]
  public async Task<IActionResult> Edit(Post post)
  {
    await postService.UpdatePostAsync(post);
    return RedirectToAction(nameof(Index));
  }
}
