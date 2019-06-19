using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public Guid AuthorId { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal Price { get; set; }
        public int TurnaroundDay { get; set; }
        public int Revisions { get; set; }
        public int Favourites { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
    }
}
