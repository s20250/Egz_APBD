using Egzamin_APBD_s20250.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace Egzamin_APBD_s20250.Controllers;

[Route("api")]
[ApiController]
public class AlbumController : ControllerBase
{
    private readonly IAlbumDb _servicecs;

    public AlbumController (IAlbumDb servicecs)
    {
        this._servicecs = servicecs;
    }
    [HttpGet("projects/{id}")]
    public async Task<IActionResult> GetProjects([FromBody] int id)
    {
        var result = await _servicecs.GetAlbum(id);

        if (result == null)
        {
            return NoContent();
        }
        else
        {
            return Ok(result);
        }
    }
    
    [HttpDelete("Musician/{id}")]
    public async Task<IActionResult> DeleteMusician([FromRoute] int id)
    {
        var result = await _servicecs.DeleteMusician(id);

        if (result != "Success!")
            return BadRequest(result);

        return Ok(result);
    }

}