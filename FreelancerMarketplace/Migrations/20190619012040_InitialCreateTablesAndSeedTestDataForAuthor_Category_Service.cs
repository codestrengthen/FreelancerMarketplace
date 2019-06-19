using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreelancerMarketplace.Migrations
{
    public partial class InitialCreateTablesAndSeedTestDataForAuthor_Category_Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(nullable: false),
                    AvatarPath = table.Column<string>(maxLength: 1000, nullable: true),
                    PublicName = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 200, nullable: false),
                    ParentCategoryId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ServiceName = table.Column<string>(maxLength: 200, nullable: false),
                    ServiceDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    TurnaroundDay = table.Column<int>(nullable: false),
                    Revisions = table.Column<int>(nullable: false),
                    Favourites = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AvatarPath", "Email", "FirstName", "LastName", "Password", "PublicName", "Username" },
                values: new object[,]
                {
                    { new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"), "", "john123@hotmail.com", "John", "McNeil", "abc123!@", "JohnDesign", "john.design" },
                    { new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"), "", "lauravoice@gmail.com", "Laurence", "Ross", "voice888^&", "LaurenceVoiceover", "laura.v" },
                    { new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"), "", "tommcl85@gmail.com", "Tom", "McLaughlin", "web093#*", "TomProgramming", "tom.laughlin" },
                    { new Guid("29682969-f27f-466f-9e3d-e806a372962d"), "", "timwp345@outlook.com", "Tim", "Nguyen", "opmnu3_#", "timwpservice", "tim.nguyen" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedDate", "IsDeleted", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Audio", new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), false, null },
                    { 2, "Design & Graphics", new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), false, null },
                    { 3, "WordPress", new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), false, null },
                    { 4, "WordPress Installation", new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), false, 3 },
                    { 5, "Website to WordPress", new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "AuthorId", "CategoryId", "CreatedDate", "Favourites", "IsDeleted", "Price", "Revisions", "ServiceDescription", "ServiceName", "TurnaroundDay" },
                values: new object[,]
                {
                    { 11, new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"), 1, new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), 3, false, 100m, 4, @"<p>I'm Laurence Ross, a full-time professional voiceover and actor. You'll find my showreels and offers for standard narration and promotional voiceovers. This offer is for game narration and character voiceovers including NSV work (Non scripted Vocals) and other related recording with game material.</p>
                                                        <p>I have my own broadcast quality studio with Neumann U87 microphones and I can provide wav, aif or mp3 files at any data rate.</p>
                                                        <p>I work fast and efficiently, 7 days a week,  to offer you a fully professional service. I will re-record any sections you are not 100% happy with at no extra charge until you are satisfied. &nbsp;
                                                        <br/> The rate you’ll pay is for up to 500 words and is for recording, editing and technically optimising using Adobe Audition professional software with all rights bought out in all media.</p>
                                                        <p>Best wishes Laurence Ross
                                                        <br/>Australia Based Professional Actor and Voiceover
                                                        </p>", "Game Narration and Character Voices - broadcast", 2 },
                    { 12, new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"), 1, new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), 11, false, 300m, 3, @"<p>I am a Australia based BBC-trained voiceover with a deep, clear voice. As well as offering a 500 word voiceover package, clients have often asked if I would narrate longer scripts for long-form training videos, e-Learning projects or audio books.  I am now pleased to offer to record your longer script in my broadcast quality studio in the UK.</p>
                                                           <p>The package is for about 5,000 words, about 30 minutes of recorded time for the fee stated.  This is a one-off payment and you have all rights to the recordings.  You will be supplied with a single studio quality 32 bit 48KHz WAV or AIF file.   If you need the full recording 'cut up' into individual files, please order the 'add on' service.</p>
                                                           <p>There are a few voice styles on the video screen above.  If you'd like to download the full set - free sample mp3 showreels of other styles, please use this link, then tell me when your order: 'Please use the voice style on 'Documentary' at 1'08"" - as an example!) DOWNLOAD DETAILED FREE VOICE SHOWREELS HERE: https://google.com</p>
                                                           <p>Best wishes</p>
                                                           <p>Laurence Ross, AUS VOICEOVER</p>", "Professional Voiceover Services - 5,000 words - Deep and clear, BBC British accent", 5 },
                    { 21, new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"), 2, new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), 370, false, 50m, 5, @"<p>About my service
                                                        <br>...........................................
                                                        <br>1. I am professional only logo designer and 9years experience on logo design.
                                                        <br>2. 100% recommended logo design service.
                                                        <br>3. Quick turnaround logo design service.
                                                        <br>4. 3 original and unique design concepts.
                                                        <br>5. Unlimited revisions until you are 100% happy.
                                                        <br>6. 100% original vector logo, without losing quality.
                                                        <br>7. Full logo file package including all files for any print/web needs.
                                                        <br>8. full money back refund if your project is not to your total satisfaction.</p>", "Professional Logo Design Service", 2 },
                    { 41, new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"), 4, new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), 84, false, 60m, 8, @"<p>I can develop a website with a given Themeforest template and make the site just like the demo. 
                                                        <br>My service will includes:
                                                        <br>- Installation of Themeforest theme. 
                                                        <br>- Exact look and feel as demo/preview website.</p>
                                                        <p>Additional Free Works:
                                                        <br>-* Screenshot image or video to help you to understand your site dashboard control.
                                                        <br>- WordPress Software Installation (if it is not installed)
                                                        <br>- Desired Logo Change
                                                        <br>- Standard plugins installation</p>", "WordPress Theme Installation & Demo Setup", 5 },
                    { 42, new Guid("29682969-f27f-466f-9e3d-e806a372962d"), 4, new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), 170, false, 50m, 2, @"<p>I am WordPress theme installation expert with 4+ years working experience and for this service I am offering :</p>
                                                    <p>1. Install WordPress ( if not yet installed )</p>
                                                    <p>2. Install Themeforest or any other Theme</p>
                                                    <p>3. Install the theme demo data provided with the theme.</p>
                                                    <p>4. Add your Logo and site title</p>
                                                    <p>5. Add your required Menu Items ( if needed )</p>
                                                    <p>6. Add SEO , Security , Anti-Spam and Caching Pugin and configure the plugins .</p>
                                                    <p>7. Take Backup and send you the backup.</p>
                                                    <p>==/ Extra Services /==</p>
                                                    <p>If you need any extra services which is not listed Above , Please leave me a message , I will give you a quote for that extra service .</p>", "WordPress Install + Theme Install + Branding", 1 },
                    { 51, new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"), 5, new DateTime(2019, 6, 19, 11, 20, 40, 653, DateTimeKind.Local).AddTicks(3524), 45, false, 250m, 1, @"<p>If you have more than 1 page or 1 page with very complex details, please contact us first to discuss the requirements before placing order.</p>
                                                    <p>What we can offer for you:
                                                    <br>- Convert HTML to Wordpress
                                                    <br>- Very fast response time
                                                    <br>- Very reliable and very responsible service</p>
                                                    <p>If the theme is going to be sold in marketplace, please mention this in the initial brief, because it will be setup differently. Otherwise, we will setup as personal use.  If the theme to be used to replace existing theme with existing content, please notify us before the project start to be included in project scope. Otherwise, integrating new theme to existing website will be considered as separate project. If you'd like HTML change/bug fix to your HTML files, to be included in project estimation, please specify before project start.</p>
                                                    <p>Check out all our reviews at: <a href='https://google.com'>https://google.com</a></p>
                                                    <p>Please note, any details that are not specifically mentioned in the initial brief (for example hidden layers in PSD, page builder/VC backend) will be excluded from project scope and will be considered as separate project after initial project is completed. After we deliver the final result, if there are changes done not by our team yet causing error or bug, additional charge may apply to fix it.</p>", "Convert HTML to WordPress", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_AuthorId",
                table: "Services",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
