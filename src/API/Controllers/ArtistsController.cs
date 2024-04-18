using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class ArtistsController : BaseApiController
{
    IArtistApp _artistApp = null;

    public ArtistsController(IArtistApp artistApp)
    {
        _artistApp = artistApp;
    }

    [HttpPost("CreateArtist")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<string> CreateArtist(Artist artist)
    {

        return await _artistApp.CreateArtist(artist);
    }
}
