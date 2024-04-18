using Application.Interfaces;
using Application.Persistence;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;
public class SongApp : ISongApp
{
    public IGenericRepository<Song> _songRepo {  get; set; }

    public SongApp(IGenericRepository<Song> songRepo) 
    {
        _songRepo = songRepo;
    }

    public async Task<string> CreateSong(Song song)
    {
        var songs = await _songRepo.GetAllAsync();

        var result = "Unable to add!";


        if(!songs.Select(x => x.Title).Contains(song.Title))
        {
            await _songRepo.AddAsync(song);

            result = "Successfully Added!";
        }

        return result;
    }

    public Task<Song> UpdateSong(Song song)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSong(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Song>> GetAllSongsByArtist(int artistId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Song>> GetAllSongsByAlbum(int albumId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Song>> GetAllSongs()
    {
        throw new NotImplementedException();
    }
}
