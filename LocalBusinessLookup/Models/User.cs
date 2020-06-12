using System.ComponentModel.DataAnnotations;

namespace LocalBusinessLookup.Models
{
  public class User
  {
    public int Id { get; set; }

    [StringLength(30)]
    public string FirstName { get; set; }

    [StringLength(30)]
    public string LastName { get; set; }
    [Required]
    [StringLength(30)]
    public string Username { get; set; }
    [Required]
    [StringLength(30)]
    public string Password { get; set; }
    public string Token { get; set; }
  }
}