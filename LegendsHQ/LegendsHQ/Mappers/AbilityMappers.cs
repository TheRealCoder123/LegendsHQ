using LegendsHQ.Domain.DTOs.AbilityDTOs;
using LegendsHQ.Domain.Entities;
using LegendsHQ.Domain.ENUMs;
using Microsoft.IdentityModel.Tokens;

namespace LegendsHQ.Mappers
{
    public class AbilityMappers
    {

        private AbilityInteractionMapper _abilityInteractionMapper = new AbilityInteractionMapper();
        private AbilityTipsMapper  _tipMapper = new AbilityTipsMapper();

        public AbilityDTO toDTO(Ability ability) {

            var interactionsDTO = ability.interactions.Select(interaction => {

                return _abilityInteractionMapper.toDTO(interaction);

            }).ToList();

            var tipsDTO = ability.tips.Select(tip => {

                return _tipMapper.toDTO(tip);

            }).ToList();

            return new AbilityDTO
            {
                ability_id = ability.ability_id,
                legend_id = ability.legend_id,
                ability_name = ability.ability_name,
                ability_description = ability.ability_description,
                ability_icon = ability.ability_icon,
                ability_type = ability.ability_type,
                interactions = interactionsDTO,
                cooldown = ability.cooldown,
                tips = tipsDTO
            };

        }

        public Ability fromDTO(AbilityDTO abilityDTO)
        {

            var interactions = abilityDTO.interactions.Select(interaction => {

                return _abilityInteractionMapper.fromDTO(interaction);
            }).ToList();

            var tip = abilityDTO.tips.Select(tip => {

                return _tipMapper.fromDTO(tip);

            }).ToList();




            return new Ability
            {
                ability_id = abilityDTO.ability_id,
                legend_id = abilityDTO.legend_id,
                ability_name = abilityDTO.ability_name,
                ability_description = abilityDTO.ability_description,
                ability_icon = abilityDTO.ability_icon,
                ability_type = abilityDTO.ability_type,
                interactions = interactions,
                cooldown = abilityDTO.cooldown,
                tips = tip
            };

        }

    }
}
