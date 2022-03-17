using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise2WebAPI.Models;
using System.IO;

namespace Exercise2WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class RandomNumberController : Controller
    {

        [HttpGet("RandomNumber/GetRandomNumber")]
        // GET: RandomNumberController
        public ActionResult<IEnumerable<clsRandom>> GetRandomNumber()
        {
            Random random = new Random();
            int num = random.Next(1,37);

            //return values
            return new[]
            {
                 new clsRandom { randomNum = num }
            };
        }

        [HttpGet("RandomNumber/GetRandomWord")]
        // GET: RandomNumberController
        public ActionResult<IEnumerable<clsRandomWord>> GetRandomWord()
        {
            string content = System.IO.File.ReadAllText("dws.txt");
            Random random = new Random();
            string[] split = content.Split(" ");
            string randomString = split[random.Next(0, split.Length - 1)];

            //return values
            return new[]
            {
                 new clsRandomWord { word = randomString }
            };
        }

    }
}
