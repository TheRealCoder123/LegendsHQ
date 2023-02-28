using LegendsHQ.Domain.DTOs;
using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;
using LegendsHQ.Domain.ENUMs;

namespace LegendsHQ.Mappers
{
    public class LegendMapper
    {

        private LegendClassMapper _legendClassMapper = new LegendClassMapper();
        private SkinMapper _skinMapper = new SkinMapper();
        private LegendVideoMapper _legendVideoMapper = new LegendVideoMapper();
        private LegendImagesMapper _legendImagesMapper = new LegendImagesMapper();
        private AbilityMappers _abilityMapper = new AbilityMappers();


        public LegendDTO toDTO(Legend legend) {

            var legendClassDTO = _legendClassMapper.toDTO(legend.legend_class);
            var legendVideoDTO = _legendVideoMapper.ToDTO(legend.video);

            var skinsDTO = legend.legend_skins.Select(skin => { return _skinMapper.ToSkinDTO(skin); }).ToList();
            var imagesDTO = legend.images.Select(image => { return _legendImagesMapper.toDTO(image); }).ToList();
            var abilitiesDTO = legend.abilities.Select(ability => { return _abilityMapper.toDTO(ability); }).ToList();



            return new LegendDTO
            {

                legend_id = legend.legend_id,
                name = legend.name,
                description = legend.description,
                slogan = legend.slogan,
                saying = legend.saying,
                age = legend.age,
                season_created = legend.season_created,
                home_planet = legend.home_planet,
                tactical_ability_name = legend.tactical_ability_name,
                passive_ability_name = legend.passive_ability_name,
                ultimate_ability_name = legend.ultimate_ability_name,
                featuring_image = legend.featuring_image,
                cost_apex_coins = legend.cost_apex_coins,
                cost_legend_tokens = legend.cost_legend_tokens,
                max_health = legend.max_health,
                max_speed = legend.max_speed,
                legend_difficulty = legend.legend_difficulty,
                legend_class = legendClassDTO,
                legend_skins = skinsDTO,
                video = legendVideoDTO,
                images = imagesDTO,
                abilities = abilitiesDTO,
            };

        }

        public Legend fromDTO(LegendDTO legendDTO)
        {

            var legendClassDTO = _legendClassMapper.fromDTO(legendDTO.legend_class);
            var legendVideoDTO = _legendVideoMapper.FromDTO(legendDTO.video);

            var skinsDTO = legendDTO.legend_skins.Select(skin => { return _skinMapper.FromSkinDTO(skin); }).ToList();
            var imagesDTO = legendDTO.images.Select(image => { return _legendImagesMapper.fromDTO(image); }).ToList();
            var abilitiesDTO = legendDTO.abilities.Select(ability => { return _abilityMapper.fromDTO(ability); }).ToList();



            return new Legend
            {

                legend_id = legendDTO.legend_id,
                name = legendDTO.name,
                description = legendDTO.description,
                slogan = legendDTO.slogan,
                saying = legendDTO.saying,
                age = legendDTO.age,
                season_created = legendDTO.season_created,
                home_planet = legendDTO.home_planet,
                tactical_ability_name = legendDTO.tactical_ability_name,
                passive_ability_name = legendDTO.passive_ability_name,
                ultimate_ability_name = legendDTO.ultimate_ability_name,
                featuring_image = legendDTO.featuring_image,
                cost_apex_coins = legendDTO.cost_apex_coins,
                cost_legend_tokens = legendDTO.cost_legend_tokens,
                max_health = legendDTO.max_health,
                max_speed = legendDTO.max_speed,
                legend_difficulty = legendDTO.legend_difficulty,
                legend_class = legendClassDTO,
                legend_skins = skinsDTO,
                video = legendVideoDTO,
                images = imagesDTO,
                abilities = abilitiesDTO,
            };

        }


    }
}
