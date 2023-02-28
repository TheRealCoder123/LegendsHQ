
using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class SkinMapper
    {



        public Skin FromSkinDTO(SkinsDTO skinDTO) {

            return new Skin
            {
                skin_id = skinDTO.skin_id,
                legend_id = skinDTO.legend_id,
                cost_crafting_materials = skinDTO.cost_crafting_materials,
                cost_legend_tokens = skinDTO.cost_legend_tokens,
                cost_apex_coins = skinDTO.cost_apex_coins,
                skin_name = skinDTO.skin_name
            };

        }

        public SkinsDTO ToSkinDTO(Skin skin)
        {

            return new SkinsDTO
            {
                skin_id = skin.skin_id,
                legend_id = skin.legend_id,
                cost_crafting_materials = skin.cost_crafting_materials,
                cost_legend_tokens = skin.cost_legend_tokens,
                cost_apex_coins = skin.cost_apex_coins,
                skin_name = skin.skin_name,
            };

        }

    }
}
