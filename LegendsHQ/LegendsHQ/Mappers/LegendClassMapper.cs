using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class LegendClassMapper
    {


        public LegendClassDTO toDTO(LegendClass legendClass) { 

            return new LegendClassDTO
            {
                class_id = legendClass.class_id,
                legend_id = legendClass.legend_id,  
                class_name = legendClass.class_name,
                class_icon = legendClass.class_icon,
                class_description = legendClass.class_description
            };

        }

        public LegendClass fromDTO(LegendClassDTO legendClassDTO) {

            return new LegendClass
            {
                class_id = legendClassDTO.class_id,
                legend_id = legendClassDTO.legend_id,
                class_name = legendClassDTO.class_name,
                class_icon = legendClassDTO.class_icon,
                class_description = legendClassDTO.class_description
            };

        }


    }
}
