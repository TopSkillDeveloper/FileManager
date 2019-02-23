using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FileManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.IdentityModel.Xml;

namespace FileManager.Controllers
{
    [Route("api/users")]
    public class UserController
    {
        private ApplicationContext db;

        public UserController(ApplicationContext context)
        {
            db = context;
            if (!db.Users.Any())
            {
                db.Users.Add(new User {name = "Василий", secondName = "Маслов", login = "Mavaal", password = "1234"});
                db.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.userId == id);
            return user;
        }

//        [HttpPost]
//        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public IActionResult Post([FromBody] User user)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Users.Add(user);
//                db.SaveChanges();
//                return OkResult(user);
//            }
//
//            return BadRequestResult();
//        }
    }
}