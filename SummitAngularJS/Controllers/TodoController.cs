using SummitAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SummitAngularJS.Controllers
{
    public class TodoController : ApiController
    {
        public TodoController()
        {
            TodoRepository.Initialize();
        }

        // GET api/todo
        public HttpResponseMessage Get()
        {
            var todos = TodoRepository.All();
            return Request.CreateResponse(HttpStatusCode.OK, todos);
        }

        // GET api/todo/5
        public HttpResponseMessage Get(int id)
        {
            var todo = TodoRepository.FindById(id);
            return Request.CreateResponse(HttpStatusCode.OK, todo);
        }

        // POST api/todo
        public void Post(Todo value)
        {
            TodoRepository.Add(value.Task);
        }

        // PUT api/todo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/todo/5
        public HttpResponseMessage Delete(int id)
        {
            TodoRepository.Remove(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
