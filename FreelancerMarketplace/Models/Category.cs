using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string CategoryName { get; set; }

        public int? ParentCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<Service> Services { get; set; }
    }
}
