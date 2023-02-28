namespace LegendsHQ.Domain.DTOs.LegendDTOs
{
    public class LegendImagesDTO
    {
        public Guid image_id { get; set; }
        public Guid legend_id { get; set; }
        public string image_url { get; set; }
        public string image_description { get; set; }
    }
}
