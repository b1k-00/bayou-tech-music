using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;
public interface ISongApp
{
    Task<string> CreateSong(Song song);

    Task<string> UpdateSong(Song song);

    Task<bool> DeleteSong(int id);

    Task<List<Song>> GetAllSongsByArtist(int artistId);

    Task<List<Song>> GetAllSongsByAlbum(int albumId);

    Task<List<Song>> GetAllSongs();


}
