
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessLookup.Models;
using Microsoft.AspNetCore.Authorization;
using LocalBusinessLookup.Services;
using Microsoft.EntityFrameworkCore;


namespace LocalBusinessLookup.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/businesses")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private LocalBusinessLookupContext _db;

    private IUserService _userService;

    public BusinessesController(LocalBusinessLookupContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    // POST api/Businesses
    [Authorize]
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/Businesses/#
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    //PUT api/Businesses/userId/BusinessId
    [Authorize]
    [HttpPut("{userId}/{id}")]
    public void Put(int userId, int id, [FromBody] Business business)
    {
      business.BusinessId = id;
      if (business.UserId == userId)
      {
        _db.Entry(business).State = EntityState.Modified;
        _db.SaveChanges();
      }
    }

    //http://localhost:5000/api/Businesses/1/9
    [Authorize]
    [HttpDelete("{userId}/{id}")]
    public void Delete(int id, int userId)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      if (businessToDelete.UserId == userId)
      {
        _db.Businesses.Remove(businessToDelete);
        _db.SaveChanges();
      }
    }

    [HttpGet("random")]
    public ActionResult<Business> Random()
    {
      var query = _db.Businesses.AsQueryable().ToList();
      List<int> idList = new List<int>();


      foreach (Business b in query)
      {
        idList.Add(b.BusinessId);
      }

      Random rand = new Random();
      int r = rand.Next(0, idList.Count);
      Console.WriteLine(r);
      return query[r];

    }


    // GET api/Businesses
    [HttpGet]
    // public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string category, string ingredients, int userId)
    public ActionResult<Dictionary<string, object>> Get(string name, string type, string description, string phoneNumber, string webSite, int userId)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type.ToLower().Contains(type.ToLower()));
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description.ToLower().Contains(description.ToLower()));
      }

      if (phoneNumber != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phoneNumber);
      }

      if (webSite != null)
      {
        query = query.Where(entry => entry.WebSite == webSite);
      }

      if (userId != 0)
      {
        query = query.Where(entry => entry.UserId == userId);
      }
      Dictionary<string, object> response = new Dictionary<string, object>();
      List<string> version = new List<string> { "version 1" };
      List<string> types = new List<string> { "restaurant", "shop" };
      response.Add("version", version);
      response.Add("types", types);
      response.Add("businesses", query);
      return response;
    }
  }

  [ApiVersion("2.0")]
  [Route("api/businesses")]
  [ApiController]
  public class BusinessesV2Controller : ControllerBase
  {
    private LocalBusinessLookupContext _db;

    private IUserService _userService;

    public BusinessesV2Controller(LocalBusinessLookupContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    // POST api/Businesses
    [Authorize]
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/Businesses/#
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    //PUT api/Businesses/userId/BusinessId
    [Authorize]
    [HttpPut("{userId}/{id}")]
    public void Put(int userId, int id, [FromBody] Business business)
    {
      business.BusinessId = id;
      if (business.UserId == userId)
      {
        _db.Entry(business).State = EntityState.Modified;
        _db.SaveChanges();
      }
    }

    //http://localhost:5000/api/Businesses/1/9
    [Authorize]
    [HttpDelete("{userId}/{id}")]
    public void Delete(int id, int userId)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      if (businessToDelete.UserId == userId)
      {
        _db.Businesses.Remove(businessToDelete);
        _db.SaveChanges();
      }
    }

    [HttpGet("random")]
    public ActionResult<Business> Random()
    {
      var query = _db.Businesses.AsQueryable().ToList();
      List<int> idList = new List<int>();


      foreach (Business b in query)
      {
        idList.Add(b.BusinessId);
      }

      Random rand = new Random();
      int r = rand.Next(0, idList.Count);
      Console.WriteLine(r);
      return query[r];

    }


    // GET api/Businesses
    [HttpGet]
    // public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string category, string ingredients, int userId)
    public ActionResult<Dictionary<string, object>> Get(string name, string type, string description, string phoneNumber, string webSite, int userId)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type.ToLower().Contains(type.ToLower()));
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description.ToLower().Contains(description.ToLower()));
      }

      if (phoneNumber != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phoneNumber);
      }

      if (webSite != null)
      {
        query = query.Where(entry => entry.WebSite == webSite);
      }

      if (userId != 0)
      {
        query = query.Where(entry => entry.UserId == userId);
      }
      Dictionary<string, object> response = new Dictionary<string, object>();
      List<string> version = new List<string> { "version 2" };
      List<string> types = new List<string> { "restaurant", "shop" };
      response.Add("version", version);
      response.Add("types", types);
      response.Add("businesses", query);
      return response;
    }
  }
}