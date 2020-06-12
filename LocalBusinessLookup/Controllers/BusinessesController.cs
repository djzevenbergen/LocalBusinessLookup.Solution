
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using LocalBusinessLookup.Env;


namespace LocalBusinessLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private LocalBusinessLookupContext _db;

    public BusinessesController(LocalBusinessLookupContext db)
    {
      _db = db;
    }

    // POST api/Businesses
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

    // GET api/Businesses
    [HttpGet]
    // public ActionResult<IEnumerable<Remedy>> Get(string name, string details, string ailment, string category, string ingredients, int userId)
    public ActionResult<Dictionary<string, object>> Get(string name, string type, string description, string phoneNumber, string webSite, int userId)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type.Contains(type));
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description.Contains(description));
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
      response.Add("types", EnvironmentVariables.Types);
      response.Add("businesses", query);
      return response;
    }
  }
}