using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public Guid AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public decimal Price { get; set; }
        public int TurnaroundDay { get; set; }
        public int Revisions { get; set; }
        public int Favourites { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
