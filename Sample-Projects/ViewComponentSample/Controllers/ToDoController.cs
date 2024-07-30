using Microsoft.AspNetCore.Mvc;
using ViewComponentSample.Models;

namespace ViewComponentSample.Controllers;

[Route("[controller]")]
public class ToDoController : Controller
{
    private readonly ToDoContext _context;
    public ToDoController(ToDoContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    public IActionResult Index(int maxPriority = 2, bool isDone = false)
    {
        var model = _context.ToDo?.ToList();
        ViewData["maxPriority"] = maxPriority;
        ViewData["isDone"] = isDone;
        return View(model);
    }
}