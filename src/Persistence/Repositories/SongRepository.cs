using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
public class SongRepository : GenericRepository<Song>
{
    private readonly BayouTechDbContext _dbContext;

    public SongRepository(BayouTechDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

}
