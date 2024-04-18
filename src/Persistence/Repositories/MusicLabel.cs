using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;
public class MusicLabelRepository : GenericRepository<MusicLabelRepository>
{
    private readonly BayouTechDbContext _dbContext;

    public MusicLabelRepository(BayouTechDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

}
