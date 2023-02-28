using LegendsHQ.Data;
using LegendsHQ.Domain.DTOs;
using LegendsHQ.Domain.Entities;
using LegendsHQ.Mappers;

namespace LegendsHQ.Repository
{
    public class LegendRepository : ILegendRepository
    {
        private readonly DatabaseContext _dbContext;

        private LegendMapper _legendMapper = new LegendMapper();



        public LegendRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Legend> AddLegendAsync(LegendDTO newLegend)
        {
            var legend = _legendMapper.fromDTO(newLegend);

            legend.legend_id = Guid.NewGuid();


            return Task.FromResult(legend);

        }

        public Task<List<Legend>> GetAllLegendsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Legend> GetLegendByIdAsync(Guid legendId)
        {
            throw new NotImplementedException();
        }
    }
}
