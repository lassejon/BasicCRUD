using Api.Dtos;
using Api.Interfaces;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KoiController : ControllerBase
{
    private readonly IService _koiService;

    public KoiController(IService koiService)
    {
        _koiService = koiService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Koi>> GetKoi(string id)
    {
        var koi = await _koiService.Get(Guid.Parse(id));

        if (koi == null)
        {
            return BadRequest();
        }
        
        return Ok(koi);
    }
    
    [HttpGet("all")]
    public ActionResult<IEnumerable<Koi>> GetKois()
    {
        var kois = _koiService.GetAll();

        return Ok(kois);
    }

    [HttpPost]
    public async Task<ActionResult> CreateKoi(KoiCreateDto koi)
    {
        var isCreated = await _koiService.Create(koi);

        if (isCreated)
        {
            return Ok();
        }

        return BadRequest();
    }
    
    [HttpPut]
    public async Task<ActionResult> UpdateKoi(Koi koi)
    {
        var isUpdated = await _koiService.Update(koi);

        if (isUpdated)
        {
            return Ok();
        }

        return BadRequest();
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteKoi(string id)
    {
        var isDeleted = await _koiService.Delete(Guid.Parse(id));

        if (isDeleted)
        {
            return Ok();
        }
        
        return BadRequest();
    }
}