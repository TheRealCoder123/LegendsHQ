using LegendsHQ.Domain.DTOs.LegendDTOs;
using LegendsHQ.Domain.Entities;

namespace LegendsHQ.Mappers
{
    public class LegendVideoMapper
    {



        public LegendVideoDTO ToDTO(LegendVideo legendVideo) {

            return new LegendVideoDTO
            {

                video_id = legendVideo.video_id,
                title = legendVideo.title,
                duration = legendVideo.duration,
                video_url = legendVideo.video_url

            };

        }

        public LegendVideo FromDTO(LegendVideoDTO legendVideoDTO) {

            return new LegendVideo
            {

                video_id = legendVideoDTO.video_id,
                title = legendVideoDTO.title,
                duration = legendVideoDTO.duration,
                video_url = legendVideoDTO.video_url

            };

        }


    }
}
