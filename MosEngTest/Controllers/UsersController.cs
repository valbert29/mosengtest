using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MosEngTest.Data.Entities;
using MosEngTest.Repositories;

namespace MosEngTest.Controllers
{
    public class UsersController : Controller
    {
        private static readonly UsersRepository _usersRepository = new();
        
        [HttpPost]
        public object Create([FromBody]User model)
        {
            var isCreated = _usersRepository.Create(model);
            return isCreated ? Ok() : BadRequest();
        }

        [HttpGet]
        public IActionResult GetById([FromRoute]int id)
        {
            var user = _usersRepository.GetById(id);
            return user == null ? BadRequest() : Ok(Json(user));
        }

        [HttpDelete]
        public object Delete([FromRoute]int id)
        {
            var isDeleted = _usersRepository.Delete(id);
            return isDeleted ? NoContent() : BadRequest();
        }
    }
}