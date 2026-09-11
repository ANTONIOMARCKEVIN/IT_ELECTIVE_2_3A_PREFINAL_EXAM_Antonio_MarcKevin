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
                // Item 1
                new ExamItem {
                    Number = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new() { "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" },
                    CorrectAnswer = "C. It allows data to persist after the application stops"
                }
            };

            return View(examItems);
        }
    }
}