using Application.DTOs.DadJoke;
using MediatR;

namespace Application.Requests.DadJoke.Commands;

public class CreateDadJokeCommand : IRequest<int>
{
    public CreateDadJokeDTO CreateDadJokeDTO { get; set; }
}
