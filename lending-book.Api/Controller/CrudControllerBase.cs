using lending_book.Api.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
namespace lending_book.Api.Controller;

[Route("[controller]")]
public class CrudControllerBase<T>(IServiceBase<T> service) : ControllerBase where T : class
{
    private readonly IServiceBase<T> _service = service;

    [HttpGet]
    public IActionResult ReadAll()
    {
        var entity = _service.ReadAll;
        if (entity == null)
        {
            return NotFound("No entities found.");
        }
        return Ok(entity());
    }

    [HttpGet("{id}")]
    public IActionResult Read(Guid id)
    {
        var entity = _service.Read(id);
        if (entity == null)
        {
            return NotFound("Entity not found.");
        }
        return Ok(entity);
    }

    [HttpPost]
    public IActionResult Create([FromBody] T entity)
    {
        _service.Create(entity);
        return CreatedAtAction(nameof(Read), entity);
    }
    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] T entity)
    {
        _service.Update(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var entity = _service.Read(id);
        if (entity == null)
        {
            return NotFound("Entity not found.");
        }
        _service.Delete(entity);
        return NoContent();
    }
}