using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class LegendVideo
    {
        [Key]
        public Guid video_id { get; set; }
        public Guid legend_id { get; set; }
        public string title { get; set; }
        public string duration { get; set; }
        public string video_url { get; set; }

    }
}
