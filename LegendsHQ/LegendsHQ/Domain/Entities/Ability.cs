using LegendsHQ.Domain.ENUMs;
using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class Ability
    {
        [Key]
        public Guid ability_id { get; set; }
        public Guid legend_id { get; set; }
        public string ability_name { get; set; }
        public string ability_icon { get; set; }
        public string ability_description { get; set; }
        public string cooldown { get; set; }
        public List<AbilityInteraction> interactions { get; set; }
        public List<AbilityTips> tips { get; set; }
        public AbilityType ability_type { get; set; }



    }
}
