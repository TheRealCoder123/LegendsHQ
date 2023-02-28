namespace LegendsHQ.Domain.DTOs.LegendDTOs
{
    public class LegendFinishersDTO
    {

        public Guid finisher_id { get; set; }
        public string finisher_name { get; set; }
        public string cost_apex_coins { get; set; }
        public string cost_crafting_materials { get; set; }
        public string cost_legend_tokens { get; set; }
        public string finisher_video_url { get; set; }

    }
}
