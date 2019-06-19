using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancerMarketplace.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FreelancerMarketplace.Models
{
    public class MarketplaceContext : DbContext
    {
        public MarketplaceContext(DbContextOptions<MarketplaceContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var now = DateTime.Now;

            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"),
                FirstName = "John",
                LastName = "McNeil",
                AvatarPath = "",
                PublicName = "JohnDesign",
                Username = "john.design",
                Password = "abc123!@",
                Email = "john123@hotmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                FirstName = "Laurence",
                LastName = "Ross",
                AvatarPath = "",
                PublicName = "LaurenceVoiceover",
                Username = "laura.v",
                Password = "voice888^&",
                Email = "lauravoice@gmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                FirstName = "Tom",
                LastName = "McLaughlin",
                AvatarPath = "",
                PublicName = "TomProgramming",
                Username = "tom.laughlin",
                Password = "web093#*",
                Email = "tommcl85@gmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                AuthorId = new Guid("29682969-f27f-466f-9e3d-e806a372962d"),
                FirstName = "Tim",
                LastName = "Nguyen",
                AvatarPath = "",
                PublicName = "timwpservice",
                Username = "tim.nguyen",
                Password = "opmnu3_#",
                Email = "timwp345@outlook.com"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Audio",
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                CategoryName = "Design & Graphics",
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 3,
                CategoryName = "WordPress",
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 4,
                CategoryName = "WordPress Installation",
                CreatedDate = now,
                ParentCategoryId = 3,
                IsDeleted = false
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 5,
                CategoryName = "Website to WordPress",
                CreatedDate = now,
                ParentCategoryId = 3,
                IsDeleted = false
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 11,
                CategoryId = 1,
                AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                ServiceName = "Game Narration and Character Voices - broadcast",
                ServiceDescription = @"<p>I'm Laurence Ross, a full-time professional voiceover and actor. You'll find my showreels and offers for standard narration and promotional voiceovers. This offer is for game narration and character voiceovers including NSV work (Non scripted Vocals) and other related recording with game material.</p>
                                        <p>I have my own broadcast quality studio with Neumann U87 microphones and I can provide wav, aif or mp3 files at any data rate.</p>
                                        <p>I work fast and efficiently, 7 days a week,  to offer you a fully professional service. I will re-record any sections you are not 100% happy with at no extra charge until you are satisfied. &nbsp;
                                        <br/> The rate you’ll pay is for up to 500 words and is for recording, editing and technically optimising using Adobe Audition professional software with all rights bought out in all media.</p>
                                        <p>Best wishes Laurence Ross
                                        <br/>Australia Based Professional Actor and Voiceover
                                        </p>",
                Favourites = 3,
                TurnaroundDay = 2,
                Price = 100,
                Revisions = 4,
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 12,
                CategoryId = 1,
                AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                ServiceName = "Professional Voiceover Services - 5,000 words - Deep and clear, BBC British accent",
                ServiceDescription = @"<p>I am a Australia based BBC-trained voiceover with a deep, clear voice. As well as offering a 500 word voiceover package, clients have often asked if I would narrate longer scripts for long-form training videos, e-Learning projects or audio books.  I am now pleased to offer to record your longer script in my broadcast quality studio in the UK.</p>
                                           <p>The package is for about 5,000 words, about 30 minutes of recorded time for the fee stated.  This is a one-off payment and you have all rights to the recordings.  You will be supplied with a single studio quality 32 bit 48KHz WAV or AIF file.   If you need the full recording 'cut up' into individual files, please order the 'add on' service.</p>
                                           <p>There are a few voice styles on the video screen above.  If you'd like to download the full set - free sample mp3 showreels of other styles, please use this link, then tell me when your order: 'Please use the voice style on 'Documentary' at 1'08"" - as an example!) DOWNLOAD DETAILED FREE VOICE SHOWREELS HERE: https://google.com</p>
                                           <p>Best wishes</p>
                                           <p>Laurence Ross, AUS VOICEOVER</p>",
                Favourites = 11,
                TurnaroundDay = 5,
                Price = 300,
                Revisions = 3,
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 21,
                CategoryId = 2,
                AuthorId = new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"),
                ServiceName = "Professional Logo Design Service",
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
                Favourites = 370,
                TurnaroundDay = 2,
                Price = 50,
                Revisions = 5,
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 41,
                CategoryId = 4,
                AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                ServiceName = "WordPress Theme Installation & Demo Setup",
                ServiceDescription = @"<p>I can develop a website with a given Themeforest template and make the site just like the demo. 
                                        <br>My service will includes:
                                        <br>- Installation of Themeforest theme. 
                                        <br>- Exact look and feel as demo/preview website.</p>
                                        <p>Additional Free Works:
                                        <br>-* Screenshot image or video to help you to understand your site dashboard control.
                                        <br>- WordPress Software Installation (if it is not installed)
                                        <br>- Desired Logo Change
                                        <br>- Standard plugins installation</p>",
                Favourites = 84,
                TurnaroundDay = 5,
                Price = 60,
                Revisions = 8,
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 51,
                CategoryId = 5,
                AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                ServiceName = "Convert HTML to WordPress",
                ServiceDescription = @"<p>If you have more than 1 page or 1 page with very complex details, please contact us first to discuss the requirements before placing order.</p>
                                    <p>What we can offer for you:
                                    <br>- Convert HTML to Wordpress
                                    <br>- Very fast response time
                                    <br>- Very reliable and very responsible service</p>
                                    <p>If the theme is going to be sold in marketplace, please mention this in the initial brief, because it will be setup differently. Otherwise, we will setup as personal use.  If the theme to be used to replace existing theme with existing content, please notify us before the project start to be included in project scope. Otherwise, integrating new theme to existing website will be considered as separate project. If you'd like HTML change/bug fix to your HTML files, to be included in project estimation, please specify before project start.</p>
                                    <p>Check out all our reviews at: <a href='https://google.com'>https://google.com</a></p>
                                    <p>Please note, any details that are not specifically mentioned in the initial brief (for example hidden layers in PSD, page builder/VC backend) will be excluded from project scope and will be considered as separate project after initial project is completed. After we deliver the final result, if there are changes done not by our team yet causing error or bug, additional charge may apply to fix it.</p>",
                Favourites = 45,
                TurnaroundDay = 7,
                Price = 250,
                Revisions = 1,
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 42,
                CategoryId = 4,
                AuthorId = new Guid("29682969-f27f-466f-9e3d-e806a372962d"),
                ServiceName = "WordPress Install + Theme Install + Branding",
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
                Favourites = 170,
                TurnaroundDay = 1,
                Price = 50,
                Revisions = 2,
                CreatedDate = now,
                IsDeleted = false
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("f3f59df5-a319-4507-85d5-26dba55f5ab2"),
                ItemId = 11,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image1.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("cdd3e7d5-b083-44d0-a3eb-f5d4318e48fe"),
                ItemId = 11,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image2.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("ca4d62a3-9661-48eb-95c5-089c4544ab74"),
                ItemId = 11,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image3.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("16e4deb9-9424-42f6-8055-fda87277be22"),
                ItemId = 12,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image1.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("409be3ac-0099-4418-aa4b-ae9f33d401f9"),
                ItemId = 12,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image2.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("bb4aeb71-c78f-4114-a75a-8ac2f35ddfb7"),
                ItemId = 12,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image3.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("7ea7f43e-9050-4221-ba77-ccd98f64f573"),
                ItemId = 12,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image4.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("82db4f17-a4ce-40a8-a361-e04603085925"),
                ItemId = 21,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image1.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("23bfce01-bbf5-46ff-8cca-8b0b8154c1af"),
                ItemId = 21,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image2.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("5d9ba06e-8790-4ac8-945d-50fb8fd92196"),
                ItemId = 21,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image3.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("787d303e-9f8b-489e-af8a-6f2d1f6507bd"),
                ItemId = 21,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image4.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("296ff26f-d0cc-4093-b4b0-80c4630f60db"),
                ItemId = 21,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image5.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("f0968ca2-2de4-466b-96bb-a0f499bde797"),
                ItemId = 41,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image1.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("a6d6c1f7-ebee-4076-b27e-d0654df3bffa"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image1.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("d3a83850-43d8-4bb1-a293-95b2e81eecb4"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image2.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("4706ce1a-88eb-4652-bcbb-608008e9a764"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image3.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("a8cda40c-1b82-4136-9b4d-973d4ec36984"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image4.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("24b2de9f-fab0-4ee7-891d-1b050f1e0541"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image5.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("c51ba81c-b8ac-4823-8130-bca0957b8e4e"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image6.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("c7293ad4-7859-42ac-aad5-732cc2f0221e"),
                ItemId = 42,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image7.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("53f3399c-7a69-42b9-ab5c-5afde7fd2c91"),
                ItemId = 51,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image1.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("03efed85-a590-4052-86a4-4b77114e0d5e"),
                ItemId = 51,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image2.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("bd010fef-a2c4-4ba1-8708-3f434388c40b"),
                ItemId = 51,
                Type = (int)ImageTypeEnum.Service,
                FileName = "Image3.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("f62294cf-306b-47da-888d-27dec03e4a5b"),
                ItemId = 1,
                Type = (int)ImageTypeEnum.Category,
                FileName = "Audio.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("cac1dec7-9f40-45f9-a7b8-81638ef46705"),
                ItemId = 2,
                Type = (int)ImageTypeEnum.Category,
                FileName = "Design_Graphics.jpg",
                CreatedDate = now
            });

            modelBuilder.Entity<AppImage>().HasData(new AppImage
            {
                ImageGuid = new Guid("423915ca-2ecf-4430-9431-93b33feca75a"),
                ItemId = 3,
                Type = (int)ImageTypeEnum.Category,
                FileName = "WordPress.png",
                CreatedDate = now
            });
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<AppImage> AppImages { get; set; }
    }
}
