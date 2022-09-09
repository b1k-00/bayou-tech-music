using Application.DTOs.DadJoke;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using Xunit;

namespace ApiIntegrationTests;

public class DadJokesControllerTests
{

    private static WebApplicationFactory<Program> _application;
    private readonly HttpClient _client;

    public DadJokesControllerTests()
    {
        _application = new WebApplicationFactory<Program>();
        _client = _application.CreateClient();
    }

    [Fact]
    public async void Get_ReturnsAll()
    {
        var response = await _client.GetAsync("/api/dad-jokes");
        response.EnsureSuccessStatusCode();

        var jokes = await response.Content.ReadFromJsonAsync<List<DadJokeDTO>>();

        //fluent assertions extension methods
        response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        jokes.Should().NotBeNull();

        //xunit asserts
        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        Assert.NotNull(jokes);
    }
}
