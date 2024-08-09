using AutoMapper;
using EShopper.Catalog.Dtos.FeatureDtos;
using EShopper.Catalog.Entities;
using EShopper.Catalog.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeaturesController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFeatures()
        {
            var values = await _featureService.GetAllAsync();
            var mappedValue = _mapper.Map<List<ResultFeatureDto>>(values);
            return Ok(mappedValue);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeatureById(string id)
        {
            var value = await _featureService.GetByIdAsync(id);
            var mappedValue = _mapper.Map<ResultFeatureByIdDto>(value);
            return Ok(mappedValue);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var Feature = _mapper.Map<Feature>(createFeatureDto);
            await _featureService.CreateAsync(Feature);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var Feature = _mapper.Map<Feature>(updateFeatureDto);
            await _featureService.UpdateAsync(Feature);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(string id)
        {
            await _featureService.RemoveAsync(id);
            return Ok();
        }
   
    }
}
