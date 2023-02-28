using LegendsHQ.Domain.DTOs.AbilityDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class AbilityInteractionMapper
    {

        public AbilityInteractionDTO toDTO(AbilityInteraction abilityInteraction) {

            return new AbilityInteractionDTO
            {

                interaction_id = abilityInteraction.interaction_id,
                ability_id = abilityInteraction.ability_id,
                interaction = abilityInteraction.interaction


            };

        }



        public AbilityInteraction fromDTO(AbilityInteractionDTO abilityInteractionDTO)
        {

            return new AbilityInteraction
            {

                interaction_id = abilityInteractionDTO.interaction_id,
                ability_id = abilityInteractionDTO.ability_id,
                interaction = abilityInteractionDTO.interaction

            };

        }



    }
}
