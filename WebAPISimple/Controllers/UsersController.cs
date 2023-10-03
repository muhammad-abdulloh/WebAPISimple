using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPISimple.Models;

namespace WebAPISimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //[HttpGet]  // malumotlarni ovolamiz
        //[HttpDelete]  // o'chiradi
        //[HttpPost] // create qiladi
        //[HttpPut] // update qiladi hammasini teng
        //[HttpPatch] // update qiladi lekin bu hammasinimas qaysidur bitta propertysini


        [HttpGet]
        [Route("bu-get-uchun")]
        public IActionResult GetUsers()
        {
            var user = new[]
            {
                new User { Id=1, FirstName="Muhammad Rizo", LastName="Komilov" },
                new User { Id=2, FirstName="Muhammad Abdulloh", LastName="Jo'rayev" },
            };

            return Ok(user);
        }

        [HttpGet]
        [Route("bu-get-uchun-ikki")]
        public IActionResult GetUsersSecond()
        {
            var user = new[]
            {
                new User { Id=1, FirstName="Saida", LastName="Holidova" },
                new User { Id=2, FirstName="Janona", LastName="Asalova" },
            };

            return Ok(user);
        }
    }
}
