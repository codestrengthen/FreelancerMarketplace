using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancerMarketplace.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreelancerMarketplace.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly MarketplaceContext _context;

        public CategoryController(MarketplaceContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();

            return categories;
        }

        private List<Category> GetTestCategoryList()
        {
            var now = DateTime.Now;
            var categories = new List<Category> {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Audio",
                    CreatedDate = now,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Design & Graphics",
                    CreatedDate = now,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "WordPress",
                    CreatedDate = now,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 4,
                    CategoryName = "WordPress Installation",
                    CreatedDate = now,
                    ParentCategoryId = 3,
                    IsDeleted = false
                }
            };
            return categories;
        }
    }
}