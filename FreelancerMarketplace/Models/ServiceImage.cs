using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models
{
    public class ServiceImage
    {
        [Key]
        public Guid ImageGuid { get; set; }
        public int ServiceId { get; set; }
        [MaxLength(200)]
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }

        public Service Service { get; set; }
    }
}
