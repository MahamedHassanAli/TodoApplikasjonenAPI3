using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using TodoApplikasjonenAPI3.Models;
using TodoApplikasjonenAPI3.Data;
using TodoApplikasjonenAPI3.Services;

namespace TodoApplikasjonenAPI3.Services
{
    public class TodosService : ITodosService
    {


        public readonly AppTodoDbContext _context;

        public TodosService(AppTodoDbContext  context)
        {
            _context = context;
            
        }

        // Hent alle Todos
        public IEnumerable<Todo> GetTodos()
        {
            return _context.TodosTask.ToList();
        }

        // Hent en Todo basert på id
        public Todo GetTodoById(int id)
        {
           return _context.TodosTask.Find(id);
        }
            
           

        // Legg til ny Todo
        public void AddTodo(Todo todo)
        {
            _context.TodosTask.Add(todo);
            _context.SaveChanges();
            
        }

        // Oppdater eksisterende Todo
        public void UpdateTodo(int id, Todo updatedTodo)
        {
            var todo = _context.TodosTask.Find(id);
            if (todo == null) return; // Hvis todo ikke finnes, gjør ingenting

            todo.Title = updatedTodo.Title;
            todo.Description = updatedTodo.Description;
            todo.IsCompleted = updatedTodo.IsCompleted;
            _context.SaveChanges();

            
        }

        // Slett Todo basert på id
        public void DeleteTodo(int id)
        {
            var todo = _context.TodosTask.Find(id);
            _context.TodosTask.Remove(todo);
            _context.SaveChanges();
            
        }
    }
}
