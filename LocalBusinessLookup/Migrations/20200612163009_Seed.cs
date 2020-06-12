using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessLookup.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Name", "PhoneNumber", "Type", "UserId", "WebSite" },
                values: new object[,]
                {
                    { 10, "A bold, bland take on the popular California burrito", "Jeff's Burritos", "4355552221", "restaurant", 1, "https://www.google.com/" },
                    { 11, "Castor oil rubbed into the scalp, every night before bed, for one week.", "Juan's Pizza Palace", "8468618684", "restaurant", 2, "castor oil" },
                    { 2, "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.", "Joly Jands Joliday Joopla", "7878799456", "restaurant", 2, "https://www.google.com/" },
                    { 3, "Mega doses of Omega 3s for LIFE!!!!", "Don't Eat Anywhere Else", "3743453457", "restaurant", 1, "https://www.google.com/" },
                    { 4, "Soak the affected area in apple cider vinegar twice a day until cured", "Mycelium and Moss", "9757567677", "shop", 2, "https://www.google.com/" },
                    { 5, "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", "The Soap Shop", "3684568654", "shop", 1, "https://www.google.com/" },
                    { 6, "apply earl grey tea to the affected area 5 times a day until burn goes away", "Get Wellness!", "8141465465", "shop", 2, "https://www.google.com/" },
                    { 7, "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", "I Need", "6565656565", "shop", 1, "lemon" },
                    { 8, "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", "Good Times Clock Shop", "9876543212", "shop", 2, "https://www.google.com/" },
                    { 9, "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", "Zebra Print Bread", "0212121212", "restaurant", 1, "https://www.google.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 11);
        }
    }
}
