using LegendsHQ.Domain.DTOs.AbilityDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class AbilityTipsMapper
    {

        public AbilityTipsDTO toDTO(AbilityTips abilityTips) {

            return new AbilityTipsDTO
            {
                tip_id = abilityTips.tip_id,
                ability_id = abilityTips.ability_id,
                tip = abilityTips.tip
            };

        }


        public AbilityTips fromDTO(AbilityTipsDTO abilityTipsDTO)
        {

            return new AbilityTips
            {
                tip_id = abilityTipsDTO.tip_id,
                ability_id = abilityTipsDTO.ability_id,
                tip = abilityTipsDTO.tip
            };

        }


    }
}
