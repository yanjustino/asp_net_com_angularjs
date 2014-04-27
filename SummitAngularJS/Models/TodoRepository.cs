using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummitAngularJS.Models
{
    public class TodoRepository
    {
        private static List<Todo> Todos = new List<Todo>();

        public static void Initialize()
        {
            if (Todos.Count > 0) return;

            Add("Teste 1");
            Add("Teste 2");
            Add("Teste 3");
        }

        public static void Add(string task)
        {
            var todo = new Todo(task, MaxId());
            Todos.Add(todo);
        }

        public static void Remove(int id)
        {
            var todo = FindById(id);
            if (todo != null) Todos.Remove(todo);
        }

        public static Todo FindById(int id)
        {
            return Todos.Where(x => x.Id == id).FirstOrDefault();
        }

        public static IEnumerable<Todo> All()
        {
            return Todos;
        }

        private static int MaxId()
        {
            return Todos.Count() == 0 ? 1 : Todos.Max(x => x.Id);
        }
    }
}