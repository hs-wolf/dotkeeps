using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotKeeps.Server.Data;
using DotKeeps.Shared;

namespace DotKeeps.Server.Controllers;

[Route("api/keep-items")]
[ApiController]
public class KeepItemsController(AppDbContext context) : ControllerBase
{
  private readonly AppDbContext _context = context;

  [HttpGet]
  public async Task<ActionResult<IEnumerable<KeepItem>>> GetKeepItems()
  {
    return await _context.KeepItems.ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<KeepItem>> GetKeepItem(string id)
  {
    var keepItem = await _context.KeepItems.FindAsync(id);
    if (keepItem == null)
    {
      return NotFound();
    }
    return keepItem;
  }

  [HttpPost]
  public async Task<ActionResult<KeepItem>> PostKeepItem(KeepItem keepItem)
  {
    string NewId = Guid.NewGuid().ToString();
    DateTime CurrentDate = DateTime.Now;
    keepItem.Id = NewId;
    keepItem.CreatedAt = CurrentDate;
    keepItem.UpdatedAt = CurrentDate;
    _context.KeepItems.Add(keepItem);
    await _context.SaveChangesAsync();
    return CreatedAtAction("GetKeepItem", new { id = keepItem.Id }, keepItem);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> PutKeepItem(string id, KeepItem keepItem)
  {
    if (id != keepItem.Id)
    {
      return BadRequest();
    }
    _context.Entry(keepItem).State = EntityState.Modified;

    try
    {
      await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!KeepItemExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }

    return NoContent();
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteKeepItem(string id)
  {
    var keepItem = await _context.KeepItems.FindAsync(id);

    if (keepItem == null)
    {
      return NotFound();
    }

    _context.KeepItems.Remove(keepItem);
    await _context.SaveChangesAsync();

    return NoContent();
  }

  private bool KeepItemExists(string id)
  {
    return _context.KeepItems.Any(e => e.Id == id);
  }
}