using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Domain.Models;

namespace MyBlog.Controllers;

[Authorize]
public class ProfileController : Controller
{
  private readonly UserManager<IdentityUser> _userManager;
  private readonly SignInManager<IdentityUser> _signInManager;

  public ProfileController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
  {
    _userManager = userManager;
    _signInManager = signInManager;
  }

  public async Task<IActionResult> Index()
  {
    var user = await _userManager.GetUserAsync(User);
    if (user == null) return NotFound();

    // Load user-specific data if needed
    var profileModel = new Profile()
    {
      Name = user.UserName ?? "Anonymous",
      Email = user.Email ?? "Anon",
      ProfilePicture = "/uploads/default-profile-picture.png" // Adjust if you have user-uploaded profile pictures
    };
    return View(profileModel);
  }

  [HttpPost]
  public async Task<IActionResult> Logout()
  {
    await _signInManager.SignOutAsync();
    return RedirectToAction("Index", "Home");
  }
}