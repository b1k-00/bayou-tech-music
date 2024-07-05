using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;
public interface IAlbumApp
{
    Task<string> CreateAlbum(Album album);

    Task<string> UpdateAlbum(Album album);


    Task<string> DeleteAlbum(string albumId);

    Task<List<Album>> GetAllAlbums();



}
