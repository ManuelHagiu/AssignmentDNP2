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
    public class UsersController : ControllerBase
    {
        private readonly IUserLogin _userLogin;

        public UsersController(IUserLogin userLogin)
        {
            _userLogin = userLogin;
        }

   
        [HttpGet("{userName}")]
        public async Task<ActionResult<User>> GetUser(string userName)
        {

            try
            {
                User user = await _userLogin.ValidateUser(userName);
                if (user != null)
                {
                    return Ok(user);
                }
                    
                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}