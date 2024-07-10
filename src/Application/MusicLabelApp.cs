using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;
public class MusicLabelApp : IMusicLabel
{
    public Task<string> CreateMusicLabel(MusicLabel musicLabel)
    {
        throw new NotImplementedException();
    }

    public Task<string> DeleteMusicLabel(int musicLabelId)
    {
        throw new NotImplementedException();
    }

    public Task<List<MusicLabel>> GetAllMusicLabels()
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateMusicLabel(MusicLabel musicLabel)
    {
        throw new NotImplementedException();
    }
}
// test02