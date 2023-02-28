using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class Skin
    {
        [Key]
        public Guid skin_id { get; set; }
        public Guid legend_id { get; set; }
        public string cost_crafting_materials { get; set; }
        public string cost_legend_tokens { get; set; }
        public string cost_apex_coins { get; set; }
        public string skin_name { get; set; }

    }
}
