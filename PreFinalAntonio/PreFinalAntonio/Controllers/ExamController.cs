using Microsoft.AspNetCore.Mvc;
using PreFinalAntonio.Models;
using System.Collections.Generic;

namespace PreFinalAntonio.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var examItems = new List<ExamItem>
            {
                
                new ExamItem {
                    Number = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new() { "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" },
                    CorrectAnswer = "C. It allows data to persist after the application stops"
                },
                new ExamItem {
                    Number = 2,
                    QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Options = new() { "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" },
                    CorrectAnswer = "B. Database-First"
                },
                new ExamItem {
                    Number = 3,
                    QuestionText = "What is the primary purpose of Entity Framework Core?",
                    Options = new() { "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" },
                    CorrectAnswer = "C. To map objects in code to relational database data"
                },
                new ExamItem {
                    Number = 4,
                    QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                    Options = new() { "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" },
                    CorrectAnswer = "A. DbContext"
                }

            };

            return View(examItems);
        }
    }
}