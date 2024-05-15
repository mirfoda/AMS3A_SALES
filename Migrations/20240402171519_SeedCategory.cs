using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMS3A.Sales.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {     
    
       migrationBuilder.Sql("Insert into Category(Id,Description,IsActive,ImageUrl) Values('59270535-5d50-4a52-b008-6cf7fd7824b6', 'Pizzas',1,'pizza.jpeg') ");
        migrationBuilder.Sql("Insert Into Category(Id,Description,IsActive,ImageURL)Values(2e4bf3fa-3a01-4a53-adbb-ce6f176e0b38, 'bebidas',1,'bebidas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
