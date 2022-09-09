using Application.Persistence;
using Domain;

namespace Persistence.Repositories;

public class DadJokeRepository : GenericRepository<DadJoke>, IDadJokeRepository
{
    private readonly JuniorAssociateDbContext _dbContext;

    public DadJokeRepository(JuniorAssociateDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task RateDadJokeAsync(int dadJokeId, int rating)
    {
        var dadJoke = await _dbContext.DadJokes.FindAsync(dadJokeId);

        if(dadJoke != null)
        {
            dadJoke.Rating = rating;
            _dbContext.Update(dadJoke);
            await _dbContext.SaveChangesAsync();
        }
    }
}
