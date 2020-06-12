using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using LocalBusinessLookup.Env;
namespace LocalBusinessLookup.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }
    [StringLength(300)]
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public string WebSite { get; set; }
    public int UserId { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      // List<string> types = new List<string> { "restaurant", "shop" };

      if (!EnvironmentVariables.Types.Contains(Type))
      {
        yield return new ValidationResult(
            $"Please either use {EnvironmentVariables.Types[0]} or {EnvironmentVariables.Types[1]}",
            new[] { "Type" });
      }
    }

  }
}