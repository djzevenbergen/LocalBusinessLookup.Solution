using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using LocalBusinessLookup.Models;
using LocalBusinessLookup.Helpers;

namespace LocalBusinessLookup.Services
{
  public interface IUserService
  {
    User Authenticate(string username, string password);
    IEnumerable<User> GetAll();
  }

  public class UserService : IUserService
  {
    // users hardcoded for simplicity, store in a db with hashed passwords in production applications
    // private List<User> _users = new List<User>
    //     {
    //         new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
    //     };

    private LocalBusinessLookupContext _users;

    private readonly AppSettings _appSettings;

    public UserService(IOptions<AppSettings> appSettings, LocalBusinessLookupContext db)
    {
      _appSettings = appSettings.Value;
      _users = db;
    }

    public User Authenticate(string username, string password)
    {

      Console.WriteLine($"%%%+%+! {username}");
      var user = _users.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
      Console.WriteLine($"%%%+%+! {user.Username} {user.Password}");
      // return null if user not found
      if (user == null)
      {
        return null;
      }

      // authentication successful so generate jwt token
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
          {
            new Claim(ClaimTypes.Name, user.Id.ToString())
          }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      Console.WriteLine($"|||||||||||| tokenDescriptor: {tokenDescriptor}");
      var token = tokenHandler.CreateToken(tokenDescriptor);
      Console.WriteLine($"===={key[0]}");
      user.Token = tokenHandler.WriteToken(token);

      // remove password before returning
      user.Password = null;
      return user;
    }

    public IEnumerable<User> GetAll()
    {
      // return users without passwords
      List<User> u = new List<User> { };
      u = _users.Users.ToList();
      return u.Select(x =>
      {
        x.Password = null;
        return x;
      });
    }
  }
}
