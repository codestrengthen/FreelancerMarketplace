using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancerMarketplace.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private List<Service> AllServices { get; set; }
        public ServiceController()
        {
            GetTestServices();
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Service>> GetServiceItems(int id)
        {
            return AllServices.Where(s => s.CategoryId == id).ToList();
        }
        private void GetTestServices()
        {
            var now = DateTime.Now;
            AllServices = new List<Service>()
            {
                new Service()
                {
                    ServiceId = 11,
                    CategoryId = 1,
                    AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                    ServiceName = "Game Narration and Character Voices - broadcast",
                    ServiceDescription = @"<p>I'm Laurence Ross, a full-time professional voiceover and actor. You'll find my showreels and offers for standard narration and promotional voiceovers. This offer is for game narration and character voiceovers including NSV work (Non scripted Vocals) and other related recording with game material.</p>
                                        <p>I have my own broadcast quality studio with Neumann U87 microphones and I can provide wav, aif or mp3 files at any data rate.</p>
                                        <p>I work fast and efficiently, 7 days a week,  to offer you a fully professional service. I will re-record any sections you are not 100% happy with at no extra charge until you are satisfied. &nbsp;
                                        <br/> The rate you’ll pay is for up to 500 words and is for recording, editing and technically optimising using Adobe Audition professional software with all rights bought out in all media.</p>
                                        <p>Best wishes Laurence Ross
                                        <br/>Australia Based Professional Actor and Voiceover
                                        </p>",
                    Favourites = 3,
                    TurnaroundDay = 2,
                    Price = 100,
                    Revisions = 4,
                    CreatedDate = now,
                    IsDeleted = false
                },
                new Service()
                {
                    ServiceId = 12,
                    CategoryId = 1,
                    AuthorId = new Guid("45295ed2-1ccf-43d1-ad97-e3ce99a2e7a5"),
                    ServiceName = "Professional Voiceover Services - 5,000 words - Deep and clear, BBC British accent",
                    ServiceDescription = @"<p>I am a Australia based BBC-trained voiceover with a deep, clear voice. As well as offering a 500 word voiceover package, clients have often asked if I would narrate longer scripts for long-form training videos, e-Learning projects or audio books.  I am now pleased to offer to record your longer script in my broadcast quality studio in the UK.</p>
                                           <p>The package is for about 5,000 words, about 30 minutes of recorded time for the fee stated.  This is a one-off payment and you have all rights to the recordings.  You will be supplied with a single studio quality 32 bit 48KHz WAV or AIF file.   If you need the full recording 'cut up' into individual files, please order the 'add on' service.</p>
                                           <p>There are a few voice styles on the video screen above.  If you'd like to download the full set - free sample mp3 showreels of other styles, please use this link, then tell me when your order: 'Please use the voice style on 'Documentary' at 1'08"" - as an example!) DOWNLOAD DETAILED FREE VOICE SHOWREELS HERE: https://google.com</p>
                                           <p>Best wishes</p>
                                           <p>Laurence Ross, AUS VOICEOVER</p>",
                    Favourites = 11,
                    TurnaroundDay = 5,
                    Price = 300,
                    Revisions = 3,
                    CreatedDate = now,
                    IsDeleted = false
                },
                new Service()
                {
                    ServiceId = 21,
                    CategoryId = 2,
                    AuthorId = new Guid("c64e867f-f28d-4c2b-ba06-597bdc1ed6d3"),
                    ServiceName = "Professional Logo Design Service",
                    ServiceDescription = @"<p>About my service
                                        <br>...........................................
                                        <br>1. I am professional only logo designer and 9years experience on logo design.
                                        <br>2. 100% recommended logo design service.
                                        <br>3. Quick turnaround logo design service.
                                        <br>4. 3 original and unique design concepts.
                                        <br>5. Unlimited revisions until you are 100% happy.
                                        <br>6. 100% original vector logo, without losing quality.
                                        <br>7. Full logo file package including all files for any print/web needs.
                                        <br>8. full money back refund if your project is not to your total satisfaction.</p>",
                    Favourites = 370,
                    TurnaroundDay = 2,
                    Price = 50,
                    Revisions = 5,
                    CreatedDate = now,
                    IsDeleted = false
                },
                new Service()
                {
                    ServiceId = 41,
                    CategoryId = 4,
                    AuthorId = new Guid("6af924a5-1ab8-4df5-8b46-cfc13bfb574f"),
                    ServiceName = "WordPress Theme Installation & Demo Setup",
                    ServiceDescription = @"<p>I can develop a website with a given Themeforest template and make the site just like the demo. 
                                        <br>My service will includes:
                                        <br>- Installation of Themeforest theme. 
                                        <br>- Exact look and feel as demo/preview website.</p>
                                        <p>Additional Free Works:
                                        <br>-* Screenshot image or video to help you to understand your site dashboard control.
                                        <br>- WordPress Software Installation (if it is not installed)
                                        <br>- Desired Logo Change
                                        <br>- Standard plugins installation</p>",
                    Favourites = 84,
                    TurnaroundDay = 5,
                    Price = 60,
                    Revisions = 8,
                    CreatedDate = now,
                    IsDeleted = false
                }
            };
        }
    }
}