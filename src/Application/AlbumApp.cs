using Application.Interfaces;
using Application.Persistence;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;
public class AlbumApp : IAlbumApp
{
    public IGenericRepository<AlbumApp> _albumRepo { get; set; }

    public AlbumApp(IGenericRepository<AlbumApp> albumRepo)
    {
        _albumRepo = albumRepo;
    }

    public Task<string> CreateAlbum(Album album)
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateAlbum(Album album)
    {
        throw new NotImplementedException();
    }

    public Task<string> DeleteAlbum(string albumId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Album>> GetAllAlbums()
    {
        throw new NotImplementedException();
    }

    public Task<string> DeleteAlbum(int albumId)
    {
        throw new NotImplementedException();
    }
}
