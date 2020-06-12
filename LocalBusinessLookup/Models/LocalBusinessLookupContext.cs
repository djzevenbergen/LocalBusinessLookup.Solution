using Microsoft.EntityFrameworkCore;

namespace LocalBusinessLookup.Models
{
  public class LocalBusinessLookupContext : DbContext
  {
    public LocalBusinessLookupContext(DbContextOptions<LocalBusinessLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
      .HasData(
      new Business { BusinessId = 10, Name = "Jeff's Burritos", Description = "A bold, bland take on the popular California burrito", PhoneNumber = "4355552221", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 1 },
      new Business { BusinessId = 11, Name = "Juan's Pizza Palace", Description = "Castor oil rubbed into the scalp, every night before bed, for one week.", PhoneNumber = "8468618684", Type = "restaurant", WebSite = "castor oil", UserId = 2 },
      new Business { BusinessId = 2, Name = "Joly Jands Joliday Joopla", Description = "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.", PhoneNumber = "7878799456", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 2 },
      new Business { BusinessId = 3, Name = "Don't Eat Anywhere Else", Description = "Mega doses of Omega 3s for LIFE!!!!", PhoneNumber = "3743453457", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 1 },
      new Business { BusinessId = 4, Name = "Mycelium and Moss", Description = "Soak the affected area in apple cider vinegar twice a day until cured", PhoneNumber = "9757567677", Type = "shop", WebSite = "https://www.google.com/", UserId = 2 },
      new Business { BusinessId = 5, Name = "The Soap Shop", Description = "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", PhoneNumber = "3684568654", Type = "shop", WebSite = "https://www.google.com/", UserId = 1 },
      new Business { BusinessId = 6, Name = "Get Wellness!", Description = "apply earl grey tea to the affected area 5 times a day until burn goes away", PhoneNumber = "8141465465", Type = "shop", WebSite = "https://www.google.com/", UserId = 2 },
      new Business { BusinessId = 7, Name = "I Need", Description = "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", PhoneNumber = "6565656565", Type = "shop", WebSite = "lemon", UserId = 1 },
      new Business { BusinessId = 8, Name = "Good Times Clock Shop", Description = "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", PhoneNumber = "9876543212", Type = "shop", WebSite = "https://www.google.com/", UserId = 2 },
      new Business { BusinessId = 9, Name = "Zebra Print Bread", Description = "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", PhoneNumber = "0212121212", Type = "restaurant", WebSite = "https://www.google.com/", UserId = 1 }
      );
    }
  }
}