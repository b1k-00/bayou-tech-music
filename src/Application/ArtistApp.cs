using Application.Interfaces;
using Application.Persistence;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;
public class ArtistApp : IArtistApp
{
    public IGenericRepository<Artist> _artistRepo { get; set; }

    public ArtistApp(IGenericRepository<Artist> artistRepo)
    {
        _artistRepo = artistRepo;
    }

    public async Task<string> CreateArtist(Artist artist)
    {
        var artists = await _artistRepo.GetAllAsync();

        var result = "Unable to add!";


        if (!artists.Select(x => x.ArtistName).Contains(artist.ArtistName))
        {
            await _artistRepo.AddAsync(artist);

            result = "Successfully Added!";
        }

        return result;
    }

    public async Task<List<Artist>> AllArtist()
    {
            return (await _artistRepo.GetAllAsync()).ToList();
    }

    public async Task<string> DeleteArtist(int artistId)
    {
        var artists = await _artistRepo.GetAllAsync();

        var result = "Unable to delete!";

        foreach (var artist in artists)
        {
            if (artist.Id == artistId)
            {
                await _artistRepo.DeleteAsync(artistId);

                result = "Artist Deleted!";


            }

        }

        return result;
    }

    public async Task<string> UpdateArtist(Artist artist)
    {
        var results = "update";

        try
        {
            await _artistRepo.UpdateAsync(artist);

        }
        catch (Exception ex)
        {

            results = "update failure"; ;
        }

        return results;
    }
}
