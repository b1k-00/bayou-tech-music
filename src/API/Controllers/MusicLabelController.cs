using Application;
using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class MusicLabelController : BaseApiController
{
    IMusicLabel _musicLabelApp = null;
    public MusicLabelController (IMusicLabel musicLabel)
    {
        _musicLabelApp = musicLabel;
    }


    [HttpPost("CreateMusicLabel")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<string> CreateMusicLabel(MusicLabel musicLabel)
    {
        return await _musicLabelApp.CreateMusicLabel(musicLabel);
    }
}