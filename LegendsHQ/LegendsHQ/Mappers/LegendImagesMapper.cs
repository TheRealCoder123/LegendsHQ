using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class LegendImagesMapper
    {

        public LegendImagesDTO toDTO(LegendImages legendImages) {

            return new LegendImagesDTO
            {
                image_id = legendImages.legend_id,
                legend_id = legendImages.legend_id,
                image_url = legendImages.image_url,
                image_description = legendImages.image_description

            };
        }

        public LegendImages fromDTO(LegendImagesDTO legendImage) {

            return new LegendImages
            {
                image_id = legendImage.legend_id,
                legend_id = legendImage.legend_id,
                image_url = legendImage.image_url,
                image_description = legendImage.image_description

            };

        }


    }
}
