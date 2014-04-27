using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummitAngularJS.Models
{
    public class Todo
    {
        public int Id { get; private set; }
        public string Task { get; set; }

        public Todo(string task, int id)
        {
            this.Id = id;
            this.Task = task;
        }
    }
}