using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_manager.Data.Migrations
{
    public partial class AddSubscriptionCompletedCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SubscriptionCompleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionCompleted",
                table: "AspNetUsers");
        }
    }
}
