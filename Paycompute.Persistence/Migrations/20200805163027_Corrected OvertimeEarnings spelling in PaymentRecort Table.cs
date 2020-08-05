using Microsoft.EntityFrameworkCore.Migrations;

namespace Paycompute.Persistence.Migrations
{
    public partial class CorrectedOvertimeEarningsspellinginPaymentRecortTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OveritmeEarnings",
                table: "PaymentRecords",
                newName: "OvertimeEarnings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OvertimeEarnings",
                table: "PaymentRecords",
                newName: "OveritmeEarnings");
        }
    }
}
