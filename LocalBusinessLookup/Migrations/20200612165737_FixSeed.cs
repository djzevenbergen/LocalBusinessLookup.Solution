using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessLookup.Migrations
{
    public partial class FixSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                column: "Description",
                value: "Holiday specialities from your favorite Latinx nuns!");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                column: "Description",
                value: "The only place you're allowed to eat... Ever...");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                column: "Description",
                value: "Your local purveyor of creeping slimes and fuzzy foilage.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                column: "Description",
                value: "Get clean and smell great.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6,
                column: "Description",
                value: "We got all the healthy stuff here");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7,
                column: "Description",
                value: "For whatever you need.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8,
                column: "Description",
                value: "We have clocks in all the timezones.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9,
                column: "Description",
                value: "We make bread that's partially toasted");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 11,
                column: "Description",
                value: "Pizza with an inexplicably spicy twist.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                column: "Description",
                value: "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                column: "Description",
                value: "Mega doses of Omega 3s for LIFE!!!!");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                column: "Description",
                value: "Soak the affected area in apple cider vinegar twice a day until cured");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                column: "Description",
                value: "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6,
                column: "Description",
                value: "apply earl grey tea to the affected area 5 times a day until burn goes away");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7,
                column: "Description",
                value: "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8,
                column: "Description",
                value: "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9,
                column: "Description",
                value: "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 11,
                column: "Description",
                value: "Castor oil rubbed into the scalp, every night before bed, for one week.");
        }
    }
}
