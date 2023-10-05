using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleQuote.Shared;

namespace VehicleQuote.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quotegenerate : ControllerBase
    {
        SQLconnection sqc = new SQLconnection();

        [HttpPost]

        public void QuoteGenerate(User user)
        {


            sqc.AddDetails(user);


            //return Ok();
            //return (IActionResult)sqc;


        }
        
    }
}
