//using Application.DTOs.DadJoke;
//using Application.Requests.DadJoke.Commands;
//using Application.Requests.DadJoke.Queries;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace API.Controllers;

//public class DadJokesController : BaseApiController
//{
//    private readonly ISender _mediator;

//    public DadJokesController(ISender mediator)
//    {
//        _mediator = mediator;
//    }

//    [HttpGet("{id}")]
//    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DadJokeDTO))]
//    [ProducesResponseType(StatusCodes.Status404NotFound)]
//    public async Task<IActionResult> GetDadJoke(int id)
//    {
//        var dadJoke = await _mediator.Send(new GetDadJokeDetailRequest { Id = id });

//        if (dadJoke != null)
//        {
//            return Ok(dadJoke);
//        }
//        else
//        {
//            return NotFound();
//        }

//        //return Ok(new { Id = id, Setup = "setup", Punchline = "punchline", Rating = 4 });
//    }

//    [HttpGet]
//    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<DadJokeDTO>))]
//    public async Task<IActionResult> GetDadJokes()
//    {
//        var dadJokes = await _mediator.Send(new GetDadJokeListRequest());
//        return Ok(dadJokes);

//        //return Ok(new[] {
//        //    new { Id = 1, Setup = "setup1", Punchline = "punchline1", Rating = 4 },
//        //    new { Id = 2, Setup = "setup2", Punchline = "punchline2", Rating = 4 },
//        //    new { Id = 3, Setup = "setup3", Punchline = "punchline3", Rating = 4 }
//        //    });
//    }

//    [HttpPost]
//    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
//    public async Task<IActionResult> CreateDadJoke([FromBody] CreateDadJokeDTO dadJoke)
//    {
//        var command = new CreateDadJokeCommand { CreateDadJokeDTO = dadJoke };
//        var response = await _mediator.Send(command);
//        return Ok(response);

//        //return Ok(42);
//    }

//    [HttpPut]
//    public IActionResult UpdateDadJoke()
//    {
//        return Ok(new { Id = 1, Setup = "setup", Punchline = "punchline", Rating = 4 });
//    }

//    [HttpPost("{id}/rate/{rating}")]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    public async Task<IActionResult> RateDadJoke(int id, int rating)
//    {
//        await _mediator.Send(new RateDadJokeCommand { DadJokeRatingDTO = new DadJokeRatingDTO { Id = id, Rating = rating } });
//        return Ok();
//    }

//    [HttpDelete]
//    public IActionResult DeleteDadJoke()
//    {
//        return NoContent();
//    }
//}
