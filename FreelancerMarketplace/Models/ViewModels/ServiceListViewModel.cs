using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerMarketplace.Models.ViewModels
{
    public class ServiceListViewModel
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public decimal Price { get; set; }
        public int Revisions { get; set; }
        public string PublicName { get; set; }
        public string Image { get; set; }
    }
}
