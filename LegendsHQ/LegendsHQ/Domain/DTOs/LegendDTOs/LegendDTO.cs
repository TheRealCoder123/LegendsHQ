using LegendsHQ.Domain.DTOs.AbilityDTOs;
using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;
using LegendsHQ.Domain.ENUMs;

namespace LegendsHQ.Domain.DTOs
{
    public class LegendDTO
    {

        public Guid legend_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string slogan { get; set; }
        public string saying { get; set; }
        public string age { get; set; }
        public string season_created { get; set; }
        public string home_planet { get; set; }
        public string tactical_ability_name { get; set; }
        public string passive_ability_name { get; set; }
        public string ultimate_ability_name { get; set; }
        public string featuring_image { get; set; }
        public string cost_apex_coins { get; set; }
        public string cost_legend_tokens { get; set; }
        public string max_health { get; set; }
        public string max_speed { get; set; }


        public LegendDifficulty legend_difficulty { get; set; }

        public LegendClassDTO legend_class { get; set; }
        public List<SkinsDTO> legend_skins { get; set; }
        public LegendVideoDTO video { get; set; }
        public List<LegendImagesDTO> images { get; set; }
        public List<AbilityDTO> abilities { get; set; }


    }
}
