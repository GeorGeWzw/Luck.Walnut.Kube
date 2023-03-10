using Luck.EntityFrameworkCore.DbContexts;
using Luck.Walnut.Kube.Domain.AggregateRoots.Clusters;
using Luck.Walnut.Kube.Domain.Repositories;
using Luck.Walnut.Kube.Dto.Clusteries;

namespace Luck.Walnut.Kube.Persistence.Repositories;

public class ClusterRepository : EfCoreAggregateRootRepository<Cluster, string>, IClusterRepository
{
    public ClusterRepository(ILuckDbContext dbContext) : base(dbContext)
    {
    }


    public async Task<List<ClusterOutputDto>> GetClusterOutputDtoListAsync()
    {
        return await FindAll().Select(x => new ClusterOutputDto()
        {
            Id = x.Id,
            Name = x.Name,
        }).ToListAsync();
    }

    public async Task<Cluster?> GetClusterFindByIdAsync(string id)
    {
        return await FindAll().FirstOrDefaultAsync(x => x.Id == id);
    }


    public async Task<List<Cluster>> GetAllClusterListAsync()
    {
        return await FindAll().ToListAsync();
    }
}