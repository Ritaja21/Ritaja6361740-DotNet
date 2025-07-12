using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemsController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1" },
            new Item { Id = 2, Name = "Item 2" }
        };

        [HttpGet]
        public IActionResult GetItems() => Ok(items);

        [HttpGet("{id}")]
        public IActionResult GetItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            items.Add(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateItem(int id, Item updated)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            item.Name = updated.Name;
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            items.Remove(item);
            return NoContent();
        }
    }
}
