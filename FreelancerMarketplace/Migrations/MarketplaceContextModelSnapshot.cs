﻿// <auto-generated />
using System;
using FreelancerMarketplace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreelancerMarketplace.Migrations
{
    [DbContext(typeof(MarketplaceContext))]
    partial class MarketplaceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreelancerMarketplace.Models.AppImage", b =>
                {
                    b.Property<Guid>("ImageGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FileName")
                        .HasMaxLength(200);

                    b.Property<int>("ItemId");

                    b.Property<int>("Type");

                    b.HasKey("ImageGuid");

                    b.ToTable("AppImages");

                    b.HasData(
                        new
                        {
                            ImageGuid = new Guid("f3f59df5-a319-4507-85d5-26dba55f5ab2"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image1.jpg",
                            ItemId = 11,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("cdd3e7d5-b083-44d0-a3eb-f5d4318e48fe"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image2.jpg",
                            ItemId = 11,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("ca4d62a3-9661-48eb-95c5-089c4544ab74"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image3.jpg",
                            ItemId = 11,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("16e4deb9-9424-42f6-8055-fda87277be22"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image1.jpg",
                            ItemId = 12,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("409be3ac-0099-4418-aa4b-ae9f33d401f9"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image2.jpg",
                            ItemId = 12,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("bb4aeb71-c78f-4114-a75a-8ac2f35ddfb7"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image3.jpg",
                            ItemId = 12,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("7ea7f43e-9050-4221-ba77-ccd98f64f573"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image4.jpg",
                            ItemId = 12,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("82db4f17-a4ce-40a8-a361-e04603085925"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image1.jpg",
                            ItemId = 21,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("23bfce01-bbf5-46ff-8cca-8b0b8154c1af"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image2.jpg",
                            ItemId = 21,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("5d9ba06e-8790-4ac8-945d-50fb8fd92196"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image3.jpg",
                            ItemId = 21,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("787d303e-9f8b-489e-af8a-6f2d1f6507bd"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image4.jpg",
                            ItemId = 21,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("296ff26f-d0cc-4093-b4b0-80c4630f60db"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image5.jpg",
                            ItemId = 21,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("f0968ca2-2de4-466b-96bb-a0f499bde797"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image1.jpg",
                            ItemId = 41,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("a6d6c1f7-ebee-4076-b27e-d0654df3bffa"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image1.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("d3a83850-43d8-4bb1-a293-95b2e81eecb4"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image2.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("4706ce1a-88eb-4652-bcbb-608008e9a764"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image3.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("a8cda40c-1b82-4136-9b4d-973d4ec36984"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image4.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("24b2de9f-fab0-4ee7-891d-1b050f1e0541"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image5.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("c51ba81c-b8ac-4823-8130-bca0957b8e4e"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image6.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("c7293ad4-7859-42ac-aad5-732cc2f0221e"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image7.jpg",
                            ItemId = 42,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("53f3399c-7a69-42b9-ab5c-5afde7fd2c91"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image1.jpg",
                            ItemId = 51,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("03efed85-a590-4052-86a4-4b77114e0d5e"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image2.jpg",
                            ItemId = 51,
                            Type = 2
                        },
                        new
                        {
                            ImageGuid = new Guid("bd010fef-a2c4-4ba1-8708-3f434388c40b"),
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            FileName = "Image3.jpg",
                            ItemId = 51,
                            Type = 2
                        });
                });

            modelBuilder.Entity("FreelancerMarketplace.Models.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarPath")
                        .HasMaxLength(1000);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PublicName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"),
                            AvatarPath = "",
                            Email = "john123@hotmail.com",
                            FirstName = "John",
                            LastName = "McNeil",
                            Password = "abc123!@",
                            PublicName = "JohnDesign",
                            Username = "john.design"
                        },
                        new
                        {
                            AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                            AvatarPath = "",
                            Email = "lauravoice@gmail.com",
                            FirstName = "Laurence",
                            LastName = "Ross",
                            Password = "voice888^&",
                            PublicName = "LaurenceVoiceover",
                            Username = "laura.v"
                        },
                        new
                        {
                            AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                            AvatarPath = "",
                            Email = "tommcl85@gmail.com",
                            FirstName = "Tom",
                            LastName = "McLaughlin",
                            Password = "web093#*",
                            PublicName = "TomProgramming",
                            Username = "tom.laughlin"
                        },
                        new
                        {
                            AuthorId = new Guid("29682969-f27f-466f-9e3d-e806a372962d"),
                            AvatarPath = "",
                            Email = "timwp345@outlook.com",
                            FirstName = "Tim",
                            LastName = "Nguyen",
                            Password = "opmnu3_#",
                            PublicName = "timwpservice",
                            Username = "tim.nguyen"
                        });
                });

            modelBuilder.Entity("FreelancerMarketplace.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("ParentCategoryId");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Audio",
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Design & Graphics",
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "WordPress",
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "WordPress Installation",
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            IsDeleted = false,
                            ParentCategoryId = 3
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Website to WordPress",
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            IsDeleted = false,
                            ParentCategoryId = 3
                        });
                });

            modelBuilder.Entity("FreelancerMarketplace.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("AuthorId");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Favourites");

                    b.Property<bool>("IsDeleted");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(19,4)");

                    b.Property<int>("Revisions");

                    b.Property<string>("ServiceDescription");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("TurnaroundDay");

                    b.HasKey("ServiceId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceId = 11,
                            AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                            CategoryId = 1,
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            Favourites = 3,
                            IsDeleted = false,
                            Price = 100m,
                            Revisions = 4,
                            ServiceDescription = @"<p>I'm Laurence Ross, a full-time professional voiceover and actor. You'll find my showreels and offers for standard narration and promotional voiceovers. This offer is for game narration and character voiceovers including NSV work (Non scripted Vocals) and other related recording with game material.</p>
                                        <p>I have my own broadcast quality studio with Neumann U87 microphones and I can provide wav, aif or mp3 files at any data rate.</p>
                                        <p>I work fast and efficiently, 7 days a week,  to offer you a fully professional service. I will re-record any sections you are not 100% happy with at no extra charge until you are satisfied. &nbsp;
                                        <br/> The rate you’ll pay is for up to 500 words and is for recording, editing and technically optimising using Adobe Audition professional software with all rights bought out in all media.</p>
                                        <p>Best wishes Laurence Ross
                                        <br/>Australia Based Professional Actor and Voiceover
                                        </p>",
                            ServiceName = "Game Narration and Character Voices - broadcast",
                            TurnaroundDay = 2
                        },
                        new
                        {
                            ServiceId = 12,
                            AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                            CategoryId = 1,
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            Favourites = 11,
                            IsDeleted = false,
                            Price = 300m,
                            Revisions = 3,
                            ServiceDescription = @"<p>I am a Australia based BBC-trained voiceover with a deep, clear voice. As well as offering a 500 word voiceover package, clients have often asked if I would narrate longer scripts for long-form training videos, e-Learning projects or audio books.  I am now pleased to offer to record your longer script in my broadcast quality studio in the UK.</p>
                                           <p>The package is for about 5,000 words, about 30 minutes of recorded time for the fee stated.  This is a one-off payment and you have all rights to the recordings.  You will be supplied with a single studio quality 32 bit 48KHz WAV or AIF file.   If you need the full recording 'cut up' into individual files, please order the 'add on' service.</p>
                                           <p>There are a few voice styles on the video screen above.  If you'd like to download the full set - free sample mp3 showreels of other styles, please use this link, then tell me when your order: 'Please use the voice style on 'Documentary' at 1'08"" - as an example!) DOWNLOAD DETAILED FREE VOICE SHOWREELS HERE: https://google.com</p>
                                           <p>Best wishes</p>
                                           <p>Laurence Ross, AUS VOICEOVER</p>",
                            ServiceName = "Professional Voiceover Services - 5,000 words - Deep and clear, BBC British accent",
                            TurnaroundDay = 5
                        },
                        new
                        {
                            ServiceId = 21,
                            AuthorId = new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"),
                            CategoryId = 2,
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            Favourites = 370,
                            IsDeleted = false,
                            Price = 50m,
                            Revisions = 5,
                            ServiceDescription = @"<p>About my service
                                        <br>...........................................
                                        <br>1. I am professional only logo designer and 9years experience on logo design.
                                        <br>2. 100% recommended logo design service.
                                        <br>3. Quick turnaround logo design service.
                                        <br>4. 3 original and unique design concepts.
                                        <br>5. Unlimited revisions until you are 100% happy.
                                        <br>6. 100% original vector logo, without losing quality.
                                        <br>7. Full logo file package including all files for any print/web needs.
                                        <br>8. full money back refund if your project is not to your total satisfaction.</p>",
                            ServiceName = "Professional Logo Design Service",
                            TurnaroundDay = 2
                        },
                        new
                        {
                            ServiceId = 41,
                            AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                            CategoryId = 4,
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            Favourites = 84,
                            IsDeleted = false,
                            Price = 60m,
                            Revisions = 8,
                            ServiceDescription = @"<p>I can develop a website with a given Themeforest template and make the site just like the demo. 
                                        <br>My service will includes:
                                        <br>- Installation of Themeforest theme. 
                                        <br>- Exact look and feel as demo/preview website.</p>
                                        <p>Additional Free Works:
                                        <br>-* Screenshot image or video to help you to understand your site dashboard control.
                                        <br>- WordPress Software Installation (if it is not installed)
                                        <br>- Desired Logo Change
                                        <br>- Standard plugins installation</p>",
                            ServiceName = "WordPress Theme Installation & Demo Setup",
                            TurnaroundDay = 5
                        },
                        new
                        {
                            ServiceId = 51,
                            AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                            CategoryId = 5,
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            Favourites = 45,
                            IsDeleted = false,
                            Price = 250m,
                            Revisions = 1,
                            ServiceDescription = @"<p>If you have more than 1 page or 1 page with very complex details, please contact us first to discuss the requirements before placing order.</p>
                                    <p>What we can offer for you:
                                    <br>- Convert HTML to Wordpress
                                    <br>- Very fast response time
                                    <br>- Very reliable and very responsible service</p>
                                    <p>If the theme is going to be sold in marketplace, please mention this in the initial brief, because it will be setup differently. Otherwise, we will setup as personal use.  If the theme to be used to replace existing theme with existing content, please notify us before the project start to be included in project scope. Otherwise, integrating new theme to existing website will be considered as separate project. If you'd like HTML change/bug fix to your HTML files, to be included in project estimation, please specify before project start.</p>
                                    <p>Check out all our reviews at: <a href='https://google.com'>https://google.com</a></p>
                                    <p>Please note, any details that are not specifically mentioned in the initial brief (for example hidden layers in PSD, page builder/VC backend) will be excluded from project scope and will be considered as separate project after initial project is completed. After we deliver the final result, if there are changes done not by our team yet causing error or bug, additional charge may apply to fix it.</p>",
                            ServiceName = "Convert HTML to WordPress",
                            TurnaroundDay = 7
                        },
                        new
                        {
                            ServiceId = 42,
                            AuthorId = new Guid("29682969-f27f-466f-9e3d-e806a372962d"),
                            CategoryId = 4,
                            CreatedDate = new DateTime(2019, 6, 19, 20, 17, 5, 430, DateTimeKind.Local).AddTicks(3899),
                            Favourites = 170,
                            IsDeleted = false,
                            Price = 50m,
                            Revisions = 2,
                            ServiceDescription = @"<p>I am WordPress theme installation expert with 4+ years working experience and for this service I am offering :</p>
                                    <p>1. Install WordPress ( if not yet installed )</p>
                                    <p>2. Install Themeforest or any other Theme</p>
                                    <p>3. Install the theme demo data provided with the theme.</p>
                                    <p>4. Add your Logo and site title</p>
                                    <p>5. Add your required Menu Items ( if needed )</p>
                                    <p>6. Add SEO , Security , Anti-Spam and Caching Pugin and configure the plugins .</p>
                                    <p>7. Take Backup and send you the backup.</p>
                                    <p>==/ Extra Services /==</p>
                                    <p>If you need any extra services which is not listed Above , Please leave me a message , I will give you a quote for that extra service .</p>",
                            ServiceName = "WordPress Install + Theme Install + Branding",
                            TurnaroundDay = 1
                        });
                });

            modelBuilder.Entity("FreelancerMarketplace.Models.Service", b =>
                {
                    b.HasOne("FreelancerMarketplace.Models.Author", "Author")
                        .WithMany("Services")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FreelancerMarketplace.Models.Category", "Category")
                        .WithMany("Services")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
