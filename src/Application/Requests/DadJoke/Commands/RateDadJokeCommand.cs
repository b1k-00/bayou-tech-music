using Application.DTOs.DadJoke;
using MediatR;

namespace Application.Requests.DadJoke.Commands;

//Unit is used in place of NULL
public class RateDadJokeCommand : IRequest<Unit>
{
    public DadJokeRatingDTO DadJokeRatingDTO { get; set; }
}
