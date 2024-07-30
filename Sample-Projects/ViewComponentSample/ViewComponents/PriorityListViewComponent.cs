using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewComponentSample.Models;

namespace ViewComponentSample.ViewComponents;

public class PriorityListViewComponent : ViewComponent
{
    private readonly ToDoContext _context;
    public PriorityListViewComponent(ToDoContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
    {
        var items = await GetItemsAsync(maxPriority, isDone);
        return View(items);
    }

    private async Task<List<TodoItem>?> GetItemsAsync(int maxPriority, bool isDone)
    {
        return await _context.ToDo!.Where(x => x.Priority <= maxPriority && x.IsDone == isDone).ToListAsync(); ;
    }
}