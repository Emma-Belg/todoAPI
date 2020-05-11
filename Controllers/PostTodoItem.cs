using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;
//using Microsoft.AspNetCore.Mvc.ControllerBase.CreatedAtAction;

namespace TodoAPI.Controllers
{
    public class PostTodoItem
    {
        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItemAPI(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }
    }
}