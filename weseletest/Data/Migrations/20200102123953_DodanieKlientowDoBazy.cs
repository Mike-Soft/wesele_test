using Microsoft.EntityFrameworkCore.Migrations;

namespace weseletest.Data.Migrations
{
    public partial class DodanieKlientowDoBazy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" UPDATE[dbo].[Customer] SET [Name]=('Konrad')  WHERE [Id]=(1)");
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
