using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MosEngTest.Data.Entities;
using MosEngTest.Repositories;

namespace MosEngTest.Controllers
{
    public class TodosController:Controller
    {
        private static readonly TodosRepository _todosRepository = new();
        
        [HttpPost]
        public IActionResult Create([FromBody]Todo model)
        {
            var isCreated = _todosRepository.Create(model);
            return isCreated ? Ok() : BadRequest();
        }
    }
}