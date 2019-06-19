using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }

        [MaxLength(1000)]
        public string AvatarPath { get; set; }

        [Required]
        [MaxLength(100)]
        public string PublicName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        public List<Service> Services { get; set; }
    }
}
