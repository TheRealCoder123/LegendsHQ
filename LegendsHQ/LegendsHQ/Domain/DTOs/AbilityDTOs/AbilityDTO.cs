using LegendsHQ.Domain.Entities;
using LegendsHQ.Domain.ENUMs;

namespace LegendsHQ.Domain.DTOs.AbilityDTOs
{
    public class AbilityDTO
    {
        public Guid ability_id { get; set; }
        public Guid legend_id { get; set; }
        public string ability_name { get; set; }
        public string ability_icon { get; set; }
        public string ability_description { get; set; }
        public string cooldown { get; set; }
        public List<AbilityInteractionDTO> interactions { get; set; }
        public List<AbilityTipsDTO> tips { get; set; }
        public AbilityType ability_type { get; set; }
    }
}
