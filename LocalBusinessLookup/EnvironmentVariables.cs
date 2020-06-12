using System.Collections.Generic;
namespace LocalBusinessLookup.Env
{
  public class EnvironmentVariables
  {
    public static List<string> Types { get; set; }



    public EnvironmentVariables()
    {
      Types.Add("restaurant");
      Types.Add("shop");
    }
  }
}