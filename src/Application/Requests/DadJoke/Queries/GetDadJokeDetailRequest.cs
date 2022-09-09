using Application.DTOs.DadJoke;
using MediatR;

namespace Application.Requests.DadJoke.Queries;

public class GetDadJokeDetailRequest : IRequest<DadJokeDTO>
{
    public int Id { get; set; }
}
