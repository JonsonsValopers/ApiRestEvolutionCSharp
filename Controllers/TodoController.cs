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
        [Route("")]
        public List<Todo> GetAllTodos(){
            return todoService.GetTodos();
        }
        [HttpGet]
        [Route("{id}")]
        public Todo GetByid([FromRoute] long id)
        {
            return todoService.GetTodoById(id);
        }
        [HttpPost]
        [Route("novoTodo")]
        public Todo PostTodo([FromBody] Todo todo)
        {
            return todoService.AddTodo(todo);
        }
        [HttpPut]
        [Route("status/{id}")]
        public string EditTodo([FromRoute] long id)
        {
            return todoService.editTodo(id);
        }
        [HttpDelete]
        [Route("deletar/{id}")]
        public string DeleteTodo([FromRoute] long id)
        {
            return todoService.DeleteTodo(id);
        }
    }
}