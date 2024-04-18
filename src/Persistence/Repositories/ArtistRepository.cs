using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
public class ArtistRepository : GenericRepository<Artist>
{
    private readonly BayouTechDbContext _dbContext;

    public ArtistRepository(BayouTechDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

}
