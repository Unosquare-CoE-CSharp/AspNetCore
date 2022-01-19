using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AngelaValdez.Training.Data.Migrations
{
    public partial class CreateItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var warehouseId = Guid.NewGuid().ToString();
            migrationBuilder.InsertData("Warehouses", new[] { "Id", "Name" }, new object[,] { { warehouseId, "Almacen 1" } });

            var itemId = Guid.NewGuid().ToString();
            var itemId1 = Guid.NewGuid().ToString();
            var itemId2 = Guid.NewGuid().ToString();
            migrationBuilder.InsertData("Items", new[] { "Id", "Type", "Status", "WarehouseId", "ContainerId" },
                new object[,] { { itemId, "Coke", 0, warehouseId, null  },
                { itemId1, "Box of Cokes", 1, warehouseId, null  },
                { itemId2, "Coke", 0, warehouseId, itemId1  }});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
