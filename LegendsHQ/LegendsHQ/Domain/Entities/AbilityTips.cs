using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class AbilityTips
    {
        [Key]
        public Guid tip_id { get; set; }
        public Guid ability_id { get; set; }
        public string tip { get; set; }


    }
}
