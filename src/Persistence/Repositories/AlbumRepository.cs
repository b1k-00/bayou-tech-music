using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
public class AlbumRepository : GenericRepository<AlbumRepository>
{
    private readonly BayouTechDbContext _dbContext;

    public AlbumRepository(BayouTechDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

}
