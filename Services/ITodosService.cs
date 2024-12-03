﻿using System.Collections.Generic;
using TodoApplikasjonenAPI3.Models;


namespace TodoApplikasjonenAPI3.Services
{
    public interface ITodosService
    {
        IEnumerable<Todo> GetTodos();       // Henter alle Todos
        Todo GetTodoById(int id);           // Henter en Todo basert på ID
        void AddTodo(Todo todo);            // Legger til en ny Todo
        void UpdateTodo(int id, Todo todo); // Oppdaterer en eksisterende Todo
        void DeleteTodo(int id);            // Sletter en todo basert på ID
    }
}