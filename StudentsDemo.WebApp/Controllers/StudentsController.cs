using Microsoft.AspNetCore.Mvc;
using StudentsDemo.WebApp.Models;

namespace StudentsDemo.WebApp.Controllers;

public class StudentsController : Controller
{
    private List<Student> _students;

    public StudentsController()
    {
        _students = new List<Student>
        {
            new() { Id = 0, FirstName = "Anna", LastName = "Karenina"},
            new() { Id = 0, FirstName = "Anna", LastName = "Karenina"},
        };
    }

    [Route("/students")]
    public IActionResult Students()
    {
        return View("StudentsView", _students);
    }

    [Route("/student/{id:int}")]
    public IActionResult Student(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        return View("StudentView", student);
    }
}