using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FreelancerMarketplace.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreelancerMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceImageController : ControllerBase
    {
        private readonly MarketplaceContext _context;
        public ServiceImageController(MarketplaceContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnotherImage(int id, [FromQuery]string currentImg, [FromQuery]string dir)
        {
            //extract the digit from current file name, then reconstruct the new name based on "dir" param.
            var imgNumber = Int32.Parse(Regex.Match(currentImg, @"\d").Value);
            var newImgNumber = imgNumber;
            var imgCount = await _context.ServiceImages.Where(si => si.ServiceId == id).CountAsync();

            if (dir == "prev")
            {
                //first image, circle around to get the last image
                if(imgNumber == 1)
                {
                    newImgNumber = imgCount;
                }
                else
                {
                    newImgNumber = imgNumber - 1;
                }
            }
            else if(dir == "next")
            {
                //last image, circle around to get first image
                if(imgNumber == imgCount)
                {
                    newImgNumber = 1;
                }
                else
                {
                    newImgNumber = imgNumber + 1;
                }
            }

            var newImgName = "Image" + newImgNumber + ".jpg";
            var newImg = await _context.ServiceImages
                                       .FirstOrDefaultAsync(si => si.ServiceId == id && si.FileName == newImgName);
            if (newImg == null)
                return NotFound();

            return Ok(newImg);
        }
    }
}