using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Data;
using StudentCourseRegistration.Models;

namespace StudentCourseRegistration.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View(StudentStore.GetAll());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View(student);
        }

        StudentStore.Add(student);
        TempData["SuccessMessage"] = "Student registered successfully!";
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var student = StudentStore.GetById(id);
        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }
}
