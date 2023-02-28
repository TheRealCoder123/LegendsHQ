using System.ComponentModel.DataAnnotations;

namespace LegendsHQ.Domain.Entities
{
    public class LegendClass
    {
        [Key]
        public Guid class_id { get; set; }
        public Guid legend_id { get; set; }
        public string class_name { get; set; }
        public string class_icon { get; set; }
        public string class_description { get; set; }

    }
}
