using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SynthiMarkAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisings_Users_UserId",
                table: "Advertisings");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Users_UserId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_PostIdeas_Users_UserId",
                table: "PostIdeas");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Seos_Users_UserId",
                table: "Seos");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoIdeas_Users_UserId",
                table: "VideoIdeas");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Users_UserId",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Videos",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_UserId",
                table: "Videos",
                newName: "IX_Videos_UserForegId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "VideoIdeas",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_VideoIdeas_UserId",
                table: "VideoIdeas",
                newName: "IX_VideoIdeas_UserForegId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Seos",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_Seos_UserId",
                table: "Seos",
                newName: "IX_Seos_UserForegId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Products",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_UserId",
                table: "Products",
                newName: "IX_Products_UserForegId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PostIdeas",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_PostIdeas_UserId",
                table: "PostIdeas",
                newName: "IX_PostIdeas_UserForegId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Blogs",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                newName: "IX_Blogs_UserForegId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Advertisings",
                newName: "UserForegId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisings_UserId",
                table: "Advertisings",
                newName: "IX_Advertisings_UserForegId");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Videos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "VideoIdeas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Seos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostIdeas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AdvertisingTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UserForegId",
                table: "AdvertisingTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Advertisings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisingTypes_UserForegId",
                table: "AdvertisingTypes",
                column: "UserForegId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisings_Users_UserForegId",
                table: "Advertisings",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertisingTypes_Users_UserForegId",
                table: "AdvertisingTypes",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction,
                onUpdate: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_UserForegId",
                table: "Blogs",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostIdeas_Users_UserForegId",
                table: "PostIdeas",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_UserForegId",
                table: "Products",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seos_Users_UserForegId",
                table: "Seos",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoIdeas_Users_UserForegId",
                table: "VideoIdeas",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Users_UserForegId",
                table: "Videos",
                column: "UserForegId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisings_Users_UserForegId",
                table: "Advertisings");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertisingTypes_Users_UserForegId",
                table: "AdvertisingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Users_UserForegId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_PostIdeas_Users_UserForegId",
                table: "PostIdeas");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_UserForegId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Seos_Users_UserForegId",
                table: "Seos");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoIdeas_Users_UserForegId",
                table: "VideoIdeas");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Users_UserForegId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_AdvertisingTypes_UserForegId",
                table: "AdvertisingTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "VideoIdeas");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Seos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PostIdeas");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AdvertisingTypes");

            migrationBuilder.DropColumn(
                name: "UserForegId",
                table: "AdvertisingTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Advertisings");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "Videos",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_UserForegId",
                table: "Videos",
                newName: "IX_Videos_UserId");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "VideoIdeas",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_VideoIdeas_UserForegId",
                table: "VideoIdeas",
                newName: "IX_VideoIdeas_UserId");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "Seos",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Seos_UserForegId",
                table: "Seos",
                newName: "IX_Seos_UserId");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "Products",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_UserForegId",
                table: "Products",
                newName: "IX_Products_UserId");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "PostIdeas",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PostIdeas_UserForegId",
                table: "PostIdeas",
                newName: "IX_PostIdeas_UserId");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "Blogs",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_UserForegId",
                table: "Blogs",
                newName: "IX_Blogs_UserId");

            migrationBuilder.RenameColumn(
                name: "UserForegId",
                table: "Advertisings",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisings_UserForegId",
                table: "Advertisings",
                newName: "IX_Advertisings_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisings_Users_UserId",
                table: "Advertisings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_UserId",
                table: "Blogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostIdeas_Users_UserId",
                table: "PostIdeas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seos_Users_UserId",
                table: "Seos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoIdeas_Users_UserId",
                table: "VideoIdeas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Users_UserId",
                table: "Videos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
