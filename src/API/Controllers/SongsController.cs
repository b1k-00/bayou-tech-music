using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class SongsController : BaseApiController
{
    ISongApp _songApp = null;

    public SongsController (ISongApp songApp)
    {
        _songApp = songApp;
    }

    [HttpPost("CreateSong")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<string> CreateSong(Song song)
    {

        return await _songApp.CreateSong(song);
    }
}
