namespace LegendsHQ.Domain.DTOs.LegendDTOs
{
    public class LegendClassDTO
    {
        public Guid class_id { get; set; }
        public Guid legend_id { get; set; }
        public string class_name { get; set; }
        public string class_icon { get; set; }
        public string class_description { get; set; }
    }
}
