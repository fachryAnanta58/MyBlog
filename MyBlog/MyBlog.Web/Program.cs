namespace MyBlog;

using Application.Services;
using Domain.Interfaces;
using Infrastructure;
using Infrastructure.Repositories;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ConfigureBuilder( builder );
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
    
    private static void ConfigureBuilder( WebApplicationBuilder builder )
    {
        builder.Services.AddControllersWithViews();

        var connectionString = builder.Configuration.GetConnectionString( "SqliteConnection" );
        var dbContextFactory = new MyBlogDbContextFactory( connectionString );
        
        builder.Services.AddSingleton<IPostRepository>( new PostRepository( dbContextFactory ) );
        builder.Services.AddSingleton<IProfileRepository>( new ProfileRepository( dbContextFactory ) );
        builder.Services.AddScoped<PostService>();
    }
}