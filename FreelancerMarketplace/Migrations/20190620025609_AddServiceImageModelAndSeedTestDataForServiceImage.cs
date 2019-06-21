using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreelancerMarketplace.Migrations
{
    public partial class AddServiceImageModelAndSeedTestDataForServiceImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceImages",
                columns: table => new
                {
                    ImageGuid = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceImages", x => x.ImageGuid);
                    table.ForeignKey(
                        name: "FK_ServiceImages_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.InsertData(
                table: "ServiceImages",
                columns: new[] { "ImageGuid", "CreatedDate", "FileName", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("787d303e-9f8b-489e-af8a-6f2d1f6507bd"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image4.jpg", 21 },
                    { new Guid("296ff26f-d0cc-4093-b4b0-80c4630f60db"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image5.jpg", 21 },
                    { new Guid("f0968ca2-2de4-466b-96bb-a0f499bde797"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image1.jpg", 41 },
                    { new Guid("a6d6c1f7-ebee-4076-b27e-d0654df3bffa"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image1.jpg", 42 },
                    { new Guid("d3a83850-43d8-4bb1-a293-95b2e81eecb4"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image2.jpg", 42 },
                    { new Guid("24b2de9f-fab0-4ee7-891d-1b050f1e0541"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image5.jpg", 42 },
                    { new Guid("a8cda40c-1b82-4136-9b4d-973d4ec36984"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image4.jpg", 42 },
                    { new Guid("5d9ba06e-8790-4ac8-945d-50fb8fd92196"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image3.jpg", 21 },
                    { new Guid("c51ba81c-b8ac-4823-8130-bca0957b8e4e"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image6.jpg", 42 },
                    { new Guid("c7293ad4-7859-42ac-aad5-732cc2f0221e"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image7.jpg", 42 },
                    { new Guid("53f3399c-7a69-42b9-ab5c-5afde7fd2c91"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image1.jpg", 51 },
                    { new Guid("4706ce1a-88eb-4652-bcbb-608008e9a764"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image3.jpg", 42 },
                    { new Guid("23bfce01-bbf5-46ff-8cca-8b0b8154c1af"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image2.jpg", 21 },
                    { new Guid("bb4aeb71-c78f-4114-a75a-8ac2f35ddfb7"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image3.jpg", 12 },
                    { new Guid("7ea7f43e-9050-4221-ba77-ccd98f64f573"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image4.jpg", 12 },
                    { new Guid("03efed85-a590-4052-86a4-4b77114e0d5e"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image2.jpg", 51 },
                    { new Guid("409be3ac-0099-4418-aa4b-ae9f33d401f9"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image2.jpg", 12 },
                    { new Guid("16e4deb9-9424-42f6-8055-fda87277be22"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image1.jpg", 12 },
                    { new Guid("ca4d62a3-9661-48eb-95c5-089c4544ab74"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image3.jpg", 11 },
                    { new Guid("cdd3e7d5-b083-44d0-a3eb-f5d4318e48fe"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image2.jpg", 11 },
                    { new Guid("f3f59df5-a319-4507-85d5-26dba55f5ab2"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image1.jpg", 11 },
                    { new Guid("82db4f17-a4ce-40a8-a361-e04603085925"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image1.jpg", 21 },
                    { new Guid("bd010fef-a2c4-4ba1-8708-3f434388c40b"), new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480), "Image3.jpg", 51 }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 56, 9, 22, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.CreateIndex(
                name: "IX_ServiceImages_ServiceId",
                table: "ServiceImages",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceImages");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2019, 6, 20, 12, 53, 29, 350, DateTimeKind.Local).AddTicks(1077));
        }
    }
}
