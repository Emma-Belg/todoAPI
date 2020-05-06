using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace todoAPI.Models
{
    public class PostTodoItem
    {
        // POST: api/TodoItems
[Microsoft.AspNetCore.Mvc.HttpPost]
public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
{
    _context.TodoItems.Add(todoItem);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
    return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
}
    }
}