using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4610g399-96f9-4723-c963-903425729d1k", "e757a770-1311-48e2-ac0b-1fae969cc9e1", "Administrator", "ADMINISTRATOR" },
                    { "4610g499-96f0-6723-d963-903425129v1k", "13ce70e9-f5d0-4d04-aa3e-1259b5a6aa40", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4610e399-96d9-4723-a963-903425729a1b", 0, "47a3e383-610f-4825-b9d5-aeafd67275b7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dj_edy_2001@yahoo.com", true, "System", "Admin", false, null, "DJ_EDY_2001@YAHOO.COM", "DJ_EDY_2001@YAHOO.COM", "AQAAAAEAACcQAAAAEJwMTdvY+Gul438QC2LDobd/zNs9pZSD6ehXiMtp3q26zrOck5WYJLkqoyuA2vV/+w==", null, false, "d3be8630-c6cf-4f56-8bcb-6f1752bc6b50", null, false, "dj_edy_2001@yahoo.com" },
                    { "8ca8d44d-8231-4d7c-9ee1-59169dde1ccd", 0, "195f71d3-da76-4052-ae3e-fd3ef5116ed7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dj_edy_2002@yahoo.com", true, "System", "User", false, null, "DJ_EDY_2002@YAHOO.COM", "DJ_EDY_2002@YAHOO.COM", "AQAAAAEAACcQAAAAEGNN7QUF4GgBmU9fjaYjXtFd0uR+nsLENFM91tpDlkNha2fUjWjS6pa7RNC8/39MNQ==", null, false, "965fa48e-95f2-40de-8325-50d2ebdb4c93", null, false, "dj_edy_2002@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4610g399-96f9-4723-c963-903425729d1k", "4610e399-96d9-4723-a963-903425729a1b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4610g499-96f0-6723-d963-903425129v1k", "8ca8d44d-8231-4d7c-9ee1-59169dde1ccd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4610g399-96f9-4723-c963-903425729d1k", "4610e399-96d9-4723-a963-903425729a1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4610g499-96f0-6723-d963-903425129v1k", "8ca8d44d-8231-4d7c-9ee1-59169dde1ccd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4610g399-96f9-4723-c963-903425729d1k");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4610g499-96f0-6723-d963-903425129v1k");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4610e399-96d9-4723-a963-903425729a1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ca8d44d-8231-4d7c-9ee1-59169dde1ccd");
        }
    }
}
