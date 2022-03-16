using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise2WebAPI.Models;

namespace Exercise2WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomNumberController : Controller
    {

        [HttpGet]
        // GET: RandomNumberController
        public ActionResult<List<clsRandom>> Index()
        {
            Random random = new Random();
            int num = random.Next(1,37);

            clsRandom cls = new clsRandom();
            cls.randomNum = num;
            return new JsonResult(cls);
        }

    }
}
