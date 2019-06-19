using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models
{
    public class AppImage
    {
        [Key]
        public Guid ImageGuid { get; set; }
        public int ItemId { get; set; }
        public int Type { get; set; }

        [MaxLength(200)]
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
