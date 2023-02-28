using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class LegendFinishersMapper
    {

        public LegendFinishersDTO toDTO(LegendFinishers legendFinishers) {

            return new LegendFinishersDTO
            {
                finisher_id = legendFinishers.finisher_id,
                finisher_name = legendFinishers.finisher_name,
                cost_apex_coins = legendFinishers.cost_apex_coins,
                cost_crafting_materials = legendFinishers.cost_crafting_materials,
                cost_legend_tokens = legendFinishers.cost_legend_tokens,
                finisher_video_url = legendFinishers.finisher_video_url



            };
        }

        public LegendFinishers fromDTO(LegendFinishersDTO legendFinishersDTO)
        {

            return new LegendFinishers
            {

                finisher_id = legendFinishersDTO.finisher_id,
                finisher_name = legendFinishersDTO.finisher_name,
                cost_apex_coins = legendFinishersDTO.cost_apex_coins,
                cost_crafting_materials = legendFinishersDTO.cost_crafting_materials,
                cost_legend_tokens = legendFinishersDTO.cost_legend_tokens,
                finisher_video_url = legendFinishersDTO.finisher_video_url

            };
        }

    }
}
