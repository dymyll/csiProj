using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RazzMaTazz.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestMetrics",
                columns: table => new
                {
                    RequestMetricId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apicontroller = table.Column<string>(nullable: true),
                    Apimethod = table.Column<string>(nullable: true),
                    Apiversion = table.Column<string>(nullable: true),
                    BankNumber = table.Column<int>(nullable: true),
                    Channel = table.Column<int>(nullable: true),
                    Duration = table.Column<long>(nullable: true),
                    EmpId = table.Column<long>(nullable: true),
                    PartnerKey = table.Column<string>(nullable: true),
                    ReasonPhrase = table.Column<string>(nullable: true),
                    RequestBody = table.Column<string>(nullable: true),
                    RequestCert = table.Column<string>(nullable: true),
                    ResponseBody = table.Column<string>(nullable: true),
                    ResponseCode = table.Column<int>(nullable: true),
                    ServerName = table.Column<string>(nullable: true),
                    SessionId = table.Column<long>(nullable: true),
                    SourceIp = table.Column<string>(nullable: true),
                    SourcePort = table.Column<int>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Uri = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    Verb = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMetrics", x => x.RequestMetricId);
                });

            migrationBuilder.CreateTable(
                name: "RequestMetricsExtDetails",
                columns: table => new
                {
                    RequestMetricsExtId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestDetail = table.Column<string>(nullable: true),
                    ResponseDetail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMetricsExtDetails", x => x.RequestMetricsExtId);
                });

            migrationBuilder.CreateTable(
                name: "RequestMetricsDetails",
                columns: table => new
                {
                    RequestMetricsDetailsId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeginTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    IsError = table.Column<bool>(nullable: true),
                    RequestDetail = table.Column<string>(nullable: true),
                    RequestMetricId = table.Column<long>(nullable: false),
                    RequestMetricsExtId = table.Column<long>(nullable: true),
                    RequestTime = table.Column<long>(nullable: true),
                    RequestType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMetricsDetails", x => x.RequestMetricsDetailsId);
                    table.ForeignKey(
                        name: "FK_RequestMetricsDetails_RequestMetrics_RequestMetricId",
                        column: x => x.RequestMetricId,
                        principalTable: "RequestMetrics",
                        principalColumn: "RequestMetricId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestMetricsDetails_RequestMetricId",
                table: "RequestMetricsDetails",
                column: "RequestMetricId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestMetricsDetails");

            migrationBuilder.DropTable(
                name: "RequestMetricsExtDetails");

            migrationBuilder.DropTable(
                name: "RequestMetrics");
        }
    }
}
