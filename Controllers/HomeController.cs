using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("register")]
        public IActionResult Index(Student student)
        {
            if(!ModelState.IsValid)
            {
                List<string> errorsList = new List<string>();
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorsList.Add(error.ErrorMessage);
                    }
                }

                string errors = string.Join("\n", errorsList);
                return BadRequest(errors);
                
            }
            return Content($"{student}");
        }
    }
}

