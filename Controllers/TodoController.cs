using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using apicSharp.Services;
using apicSharp.Models;

namespace apicSharp.Controllers
{
    [ApiController]
    [Route("/todos")]
    public class TodoController : ControllerBase
    {
        private static TodoService todoService = new TodoService();

        [HttpGet]
        public List<Todo> getAllTodos(){
            return todoService.GetTodos();
        }
        [HttpPost]
        [Route("novoTodo")]
        public Todo postTodo([FromBody] Todo todo)
        {
            return todoService.AddTodo(todo);
        }
        [HttpPut]
        [Route("status/{id:long}")]
        public string EditTodo([FromRoute] long id)
        {
            return todoService.editTodo(id);
        }
    }
}