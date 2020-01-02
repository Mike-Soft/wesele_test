using Microsoft.EntityFrameworkCore.Migrations;

namespace weseletest.Data.Migrations
{
    public partial class dod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql(@"SET IDENTITY_INSERT [dbo].[Customer] ON
                                 INSERT INTO [dbo].[Customer] ([Id], [Name], [LastName]) VALUES (3, N'Jan', N'Nowak')
                                 INSERT INTO [dbo].[Customer] ([Id], [Name], [LastName]) VALUES (4, N'Kamil', N'Lachowicz')
                                 SET IDENTITY_INSERT [dbo].[Customer] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
