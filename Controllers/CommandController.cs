using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_test.Models;
using webapi_test.Data;

namespace webapi_test.Controllers
{
    public class CommandController : Controller
    {// POST: api/TodoItems
        private readonly MockCommanderRepo mockCommanderRepo = new MockCommanderRepo();
           [HttpGet]
           [Route("api/[controller]")]
        public IEnumerable<Command> Get()
        {
            Console.WriteLine("fg");
            return mockCommanderRepo.GetAppCommands();
        }
    }
}
