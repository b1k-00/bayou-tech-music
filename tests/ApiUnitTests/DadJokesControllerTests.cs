using API.Controllers;
using Application.DTOs.DadJoke;
using Application.Requests.DadJoke.Queries;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ApiUnitTests;

public class DadJokesControllerTests
{
    [Fact]
    public async Task GetDadJoke_NullReturnsNotFound()
    {
        var mockMediatr = new Mock<ISender>();
        mockMediatr.Setup(x => x.Send(It.IsAny<GetDadJokeDetailRequest>(), new System.Threading.CancellationToken(false)))
            .ReturnsAsync(() => null);

        var dadJokesController = new DadJokesController(mockMediatr.Object);

        var response = await dadJokesController.GetDadJoke(42);

        //fluent assertions extension methods
        response.Should().BeOfType<NotFoundResult>();

        //xunit asserts
        Assert.IsType<NotFoundResult>(response);
    }


    [Fact]
    public async Task GetDadJoke_FoundReturnsOk()
    {
        var dadJokeDto = new DadJokeDTO
        {
            Id = 42,
            Setup = "this is a joke setup",
            Punchline = "and this is the punchline",
            Rating = 3
        };

        var mockMediatr = new Mock<ISender>();
        mockMediatr.Setup(x => x.Send(It.IsAny<GetDadJokeDetailRequest>(), new System.Threading.CancellationToken(false))).ReturnsAsync(dadJokeDto);

        var dadJokeController = new DadJokesController(mockMediatr.Object);

        var response = await dadJokeController.GetDadJoke(42);

        //fluent assertions extension methods
        response.Should().BeOfType<OkObjectResult>();
        ((OkObjectResult)response).Value.Should().BeOfType<DadJokeDTO>();
        ((OkObjectResult)response).Value.Should().BeEquivalentTo(new { Id = 42 }, options => options.ExcludingMissingMembers());

        //xunit asserts
        Assert.IsType<OkObjectResult>(response);
        Assert.IsType<DadJokeDTO>(((OkObjectResult)response).Value);
        Assert.Equal(42, ((DadJokeDTO)((OkObjectResult)response).Value).Id);
    }
}
