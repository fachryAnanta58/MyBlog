using System.Runtime.Serialization;

namespace MyBlog.Domain.Models;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Posts")]
public class Post : ModelBase
{
  public string Title { get; set; }
  public string Content { get; set; }
  
  [ForeignKey("Profile")]
  public int ProfileId { get; set; }
  public Profile Profile { get; set; }
}
