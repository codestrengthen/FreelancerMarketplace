using FreelancerMarketplace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Controllers
{
    public class AuthorController
    {
        private List<Author> AllAuthors { get; set; }

        private void GetTestAuthors()
        {
            AllAuthors = new List<Author>()
            {
                new Author()
                {
                    AuthorId = new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"),
                    FirstName = "John",
                    LastName = "McNeil",
                    AvatarPath = "",
                    PublicName = "JohnDesign",
                    Username = "john.design",
                    Password = "abc123!@",
                    Email = "john123@hotmail.com"
                },
                new Author()
                {
                    AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                    FirstName = "Laurence",
                    LastName = "Ross",
                    AvatarPath = "",
                    PublicName = "LaurenceVoiceover",
                    Username = "laura.v",
                    Password = "voice888^&",
                    Email = "lauravoice@gmail.com"
                },
                new Author()
                {
                    AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                    FirstName = "Tom",
                    LastName = "McLaughlin",
                    AvatarPath = "",
                    PublicName = "TomProgramming",
                    Username = "tom.laughlin",
                    Password = "web093#*",
                    Email = "tommcl85@gmail.com"
                }
            };
        }
    }
}
