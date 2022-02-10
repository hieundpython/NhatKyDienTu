using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhatKyDienTu.Migrations
{
    public partial class Updated_Table_ThongTinChung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lop",
                table: "ThongTinChungs");

            migrationBuilder.DropColumn(
                name: "ThanNhan",
                table: "ThongTinChungs");

            migrationBuilder.AlterColumn<int>(
                name: "TieuDoan",
                table: "ThongTinChungs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DaiDoi",
                table: "ThongTinChungs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChucVu",
                table: "ThongTinChungs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LuDoan",
                table: "ThongTinChungs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LuDoan",
                table: "ThongTinChungs");

            migrationBuilder.AlterColumn<string>(
                name: "TieuDoan",
                table: "ThongTinChungs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DaiDoi",
                table: "ThongTinChungs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ChucVu",
                table: "ThongTinChungs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Lop",
                table: "ThongTinChungs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThanNhan",
                table: "ThongTinChungs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
