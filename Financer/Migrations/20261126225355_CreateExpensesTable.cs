using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financer.Migrations
{
    public partial class CreateExpensesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id = table.Column<int>(
                        type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),

                    UserId = table.Column<int>(
                        type: "INTEGER", nullable: false),

                    Title = table.Column<string>(
                        type: "TEXT", nullable: false),

                    Amount = table.Column<decimal>(
                        type: "TEXT", nullable: false),

                    Category = table.Column<string>(
                        type: "TEXT", nullable: false),

                    ExpenseDate = table.Column<DateTime>(
                        type: "TEXT", nullable: false),

                    CreatedAt = table.Column<DateTime>(
                        type: "TEXT", nullable: false),

                    PaymentMethod = table.Column<string>(
                        type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);

                    table.ForeignKey(
                        name: "FK_Expense_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_UserId",
                table: "Expense",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expense");
        }
    }
}