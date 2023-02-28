using LegendsHQ.Data;
using LegendsHQ.Domain.DTOs;
using LegendsHQ.Domain.Entities;
using LegendsHQ.Mappers;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace LegendsHQ.Repository
{
    public class LegendRepository : ILegendRepository
    {
        private readonly DatabaseContext _dbContext;

        private LegendMapper _legendMapper = new LegendMapper();
        private AbilityInteractionMapper _abilityInteractionMapper = new AbilityInteractionMapper();



        public LegendRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Legend> AddLegendAsync(LegendDTO newLegend)
        {
            var legend = _legendMapper.fromDTO(newLegend);


            var newLegendId = Guid.NewGuid();
            var legendVideoId = Guid.NewGuid();
            var legendClassId = Guid.NewGuid();

            legend.legend_id = newLegendId;

            await _dbContext.legends.AddAsync(legend);

            legend.video.video_id = legendVideoId;
            await _dbContext.legendVideos.AddAsync(legend.video);

            legend.legend_class.class_id = legendClassId;
            await _dbContext.legendClasses.AddAsync(legend.legend_class);

            legend.images.ForEach(image => {
                image.image_id = Guid.NewGuid();
                image.legend_id = newLegendId;
                _dbContext.legendImages.AddAsync(image);
            });

            legend.legend_skins.ForEach(skins => {
                skins.skin_id = Guid.NewGuid();
                skins.legend_id = newLegendId;
                _dbContext.legendSkins.AddAsync(skins);
            });

            legend.abilities.ForEach(ability => {
                var abilityId = Guid.NewGuid();
                ability.ability_id = abilityId;
                ability.legend_id = newLegendId;

                _dbContext.abilitys.AddAsync(ability);

                ability.interactions.ForEach(interaction => {
                    interaction.interaction_id = Guid.NewGuid() ;
                    interaction.ability_id = abilityId;
                    _dbContext.abilityInteractions.AddAsync(interaction);
                });

                ability.tips.ForEach(tip => {
                    tip.tip_id = Guid.NewGuid();
                    tip.ability_id = abilityId;
                    _dbContext.abilityTips.AddAsync(tip);
                });

            });

            await _dbContext.SaveChangesAsync();


            return legend;

        }

        public async Task<IEnumerable<Legend>> GetAllLegendsAsync()
        {

            var legend = await _dbContext.legends
                .Include(x => x.legend_class)
                .Include(x => x.legend_skins)
                .Include(x => x.video)
                .Include(x => x.images)
                .Include(x => x.abilities)
                .ThenInclude(x => x.interactions)
                .Include(x => x.abilities).ThenInclude(x => x.tips)
                .ToListAsync();


            return legend;
        }

        public async Task<Legend> GetLegendByIdAsync(Guid legendId)
        {

            var legend = await _dbContext.legends
                .Include(x => x.legend_class)
                .Include(x => x.legend_skins)
                .Include(x => x.video)
                .Include(x => x.images)
                .Include(x => x.abilities)
                .ThenInclude(x => x.interactions)
                .Include(x => x.abilities).ThenInclude(x => x.tips).FirstOrDefaultAsync(x => x.legend_id == legendId);

            return legend;


        }
    }
}
