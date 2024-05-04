using Domain;

namespace Application.Interfaces;
public interface IArtistApp
{
    Task<string> CreateArtist(Artist artist);

    Task<List<Artist>> AllArtist();

    Task<string> DeleteArtist(int artistId);

    Task<string> UpdateArtist(Artist artist);
}