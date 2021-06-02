using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApp2.Models;

namespace TestWebApp2.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            var todos = new List<TodoItem>()
            {
                new TodoItem()
                {
                    Id = 1,
                    Name = "Some item one"
                },
                new TodoItem()
                {
                    Id = 2,
                    Name = "Some item two"
                },
                new TodoItem()
                {
                    Id = 3,
                    Name = "Some item three"
                },
                new TodoItem()
                {
                    Id = 4,
                    Name = "Some item four"
                },new TodoItem()
                {
                    Id = 5,
                    Name = "Some item <b>five</b>"
                },
            };
            return View(todos);
        }
    }
}
