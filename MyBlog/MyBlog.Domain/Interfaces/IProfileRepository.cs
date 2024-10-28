using MyBlog.Domain.Models;

namespace MyBlog.Domain.Interfaces;

public interface IProfileRepository
{
  Task<Profile?> GetByUserId( int userId );
}