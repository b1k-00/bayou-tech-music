using Application.DTOs.DadJoke;
using MediatR;

namespace Application.Requests.DadJoke.Commands;

//Unit is used in place of NULL
public class UpdateDadJokeCommand : IRequest<Unit>
{
    public int Id { get; set; }

    public DadJokeDTO DadJokeDTO { get; set; }
}
