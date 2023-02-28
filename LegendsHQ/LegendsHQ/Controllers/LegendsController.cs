using LegendsHQ.Domain.DTOs;
using LegendsHQ.Mappers;
using LegendsHQ.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LegendsHQ.Controllers
{
    [ApiController]
    [Route("legend")]
    public class LegendsController : Controller
    {

        private readonly ILegendRepository _legendRepository;

        private Mapper _mapper = new Mapper();

        public LegendsController(ILegendRepository legendRepository)
        {
            _legendRepository = legendRepository;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddNewLegendAsync([FromBody] LegendDTO legendDTO) {

            var addResult = await _legendRepository.AddLegendAsync(legendDTO);

            

            return Ok(_mapper.legendMapper.toDTO(addResult));

        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAllLegendsAsync() {


            var legends = await _legendRepository.GetAllLegendsAsync();

            var legendsDTO = legends.Select(legend =>
            {

                return _mapper.legendMapper.toDTO(legend);

            }).ToList();

            return Ok(legendsDTO);
        }

        [HttpGet]
        [Route("{legend_id}")]
        public async Task<IActionResult> GetLegendByIdAsync(Guid legend_id) {

            var legend = await _legendRepository.GetLegendByIdAsync(legend_id);
            var legendDTO = _mapper.legendMapper.toDTO(legend);

            if (legendDTO == null) { return NotFound(); }

            return Ok(legendDTO);

        }








    }
}
