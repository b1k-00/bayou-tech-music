using Application;
using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AlbumController : BaseApiController
{
    IAlbumApp _albumApp = null;

    public AlbumController(IAlbumApp albumApp)
    {
        _albumApp = albumApp;
    }

    [HttpPost("CreateAlbum")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<string> CreateAlbum(Album album)
    {

        return await _albumApp.CreateAlbum(album);

    }
}
