using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;
public interface IMusicLabel
{
    Task<string> CreateMusicLabel(MusicLabel musicLabel);

    Task<string> DeleteMusicLabel(int musicLabelId);

    Task<List<MusicLabel>> GetAllMusicLabels();

    Task<string> UpdateMusicLabel(MusicLabel musicLabel);

    // test01




}
