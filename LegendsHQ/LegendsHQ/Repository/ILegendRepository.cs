using LegendsHQ.Domain.DTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Repository
{
    public interface ILegendRepository
    {

        Task<Legend> AddLegendAsync(LegendDTO newLegend);
        Task<List<Legend>> GetAllLegendsAsync();
        Task<Legend> GetLegendByIdAsync(Guid legendId);

    }
}
