using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Models;
using AssignmentDNP2.Data;

namespace AssignmentDNP2.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private readonly IAdultService _adultService;

        public AdultsController(IAdultService adultService)
        {
            _adultService = adultService;
        }

      
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>>
            GetAdults( [FromQuery] String firstname, [FromQuery] String lastname)
        {
            IList<Adult> adults;
            try
            {
                IList<Adult> filteredAdults = await _adultService.GetAdultsAsync();
                if (firstname != null)
                {

                    adults = filteredAdults.Where(a => a.FirstName.Equals(firstname, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else if (lastname != null)
                {

                    adults = filteredAdults.Where(a => a.LastName.Equals(lastname, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else
                {
                    adults = await _adultService.GetAdultsAsync();
                }
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);

            }
        }

        
    }
}