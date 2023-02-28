using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class AbilityInteraction
    {
        [Key]
        public Guid? interaction_id { get; set; }
        public Guid? ability_id { get; set; }
        public string? interaction { get; set; }

    }
}
