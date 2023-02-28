using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class LegendImages
    {
        [Key]
        public Guid image_id { get; set; }
        public Guid legend_id { get; set; }
        public string image_url { get; set; }
        public string image_description { get; set; }

    }
}
