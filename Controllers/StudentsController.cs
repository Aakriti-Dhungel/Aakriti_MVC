using Microsoft.AspNetCore.Mvc;
using Aakriti_MVC.Context;
using Aakriti_MVC.Models;
using System.Linq;

namespace Aakriti_MVC.Controllers;

public class StudentsController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Display all students
    public IActionResult Index()
    {
        var students = _context.Students.ToList();
        return View(students);
    }

    // Show form to create a new student
    public IActionResult Create()
    {
        return View();
    }

    // Handle form submission for creating a new student
    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(student);
    }

    // Show form to edit a student
    public IActionResult Edit(int id)
    {
        var student = _context.Students.Find(id);
        if (student == null)
        {
            return NotFound();
        }
        return View(student);
    }

    // Handle form submission for editing a student
    [HttpPost]
    public IActionResult Edit(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(student);
    }

    // Show confirmation page to delete a student
    public IActionResult Delete(int id)
    {
        var student = _context.Students.Find(id);
        if (student == null)
        {
            return NotFound();
        }
        return View(student);
    }

    // Handle confirmation to delete the student
    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var student = _context.Students.Find(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}

