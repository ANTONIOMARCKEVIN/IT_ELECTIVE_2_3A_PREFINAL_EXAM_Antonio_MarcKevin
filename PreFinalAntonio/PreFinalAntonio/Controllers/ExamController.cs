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
                },
                new ExamItem {
                    Number = 5,
                    QuestionText = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Options = new() { "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" },
                    CorrectAnswer = "C. Generates EF Core models and a DbContext from an existing database"
                },
                new ExamItem {
                    Number = 6,
                    QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Options = new() { "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" },
                    CorrectAnswer = "B. appsettings.json"
                },
                new ExamItem {
                    Number = 7,
                    QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Options = new() { "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" },
                    CorrectAnswer = "B. One-to-Many"
                },
                new ExamItem {
                    Number = 8,
                    QuestionText = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                    Options = new() { "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" },
                    CorrectAnswer = "B. Foreign key referencing Section"
                },
                new ExamItem {
                    Number = 9,
                    QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Options = new() { "A. It stores the database password", "B. It represents a relationship to another entity", "C. It creates a new database", "D. It validates the student's name" },
                    CorrectAnswer = "B. It represents a relationship to another entity"
                },
                new ExamItem {
                    Number = 10,
                    QuestionText = "What does .Include() generally allow EF Core to do?",
                    Options = new() { "A. Delete the Section table", "B. Load related Section data together with Students", "C. Create a new Student", "D. Validate Student input" },
                    CorrectAnswer = "B. Load related Section data together with Students"
                }

            };

            return View(examItems);
        }
    }
}