using Domain;

namespace Application.Interfaces;
public interface IArtistApp
{
    Task<string> CreateArtist(Artist artist);
}