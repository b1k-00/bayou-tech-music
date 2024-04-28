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
}
