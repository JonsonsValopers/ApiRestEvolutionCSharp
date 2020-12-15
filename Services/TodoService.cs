using System.Collections.Generic;
using apicSharp.Models;

namespace apicSharp.Services
{
    public class TodoService
    {
        private static List <Todo> todoList;
        private long nextId = 1;

        public TodoService() 
        {
            todoList = new List<Todo>();
        }

        public List<Todo> GetTodos()
        {
            return todoList;
        }
        public Todo GetTodoById(long id)
        {
            return todoList.Find(todo => todo.id == id);
        }
        public Todo AddTodo(Todo novoTodo)
        {
            novoTodo.id = nextId;
            todoList.Add(novoTodo);
            nextId += 1;
            return novoTodo;
        }
        public string DeleteTodo(long id)
        {
            bool result =  todoList.Remove(todoList.Find(todo => todo.id == id));
            return !result ? "Todo não achado" : "Todo apagar com sucesso";
        }
        public string editTodo(long id)
        {
            Todo todoAchado = todoList.Find(todo => todo.id == id);
            todoAchado.AlterarStatus();
            return todoAchado == null ? "Todo não achado" : "Todo alterado com suceso";
        }
    }
}