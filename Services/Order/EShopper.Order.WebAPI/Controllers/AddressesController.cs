using AutoMapper;
using EShopper.Order.BusinnesLayer.Abstract;
using EShopper.Order.DtoLayer.AddressDtos;
using EShopper.Order.EntityLayer.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Order.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;
        public AddressesController(IAddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAddressList()
        {
            var values = _addressService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            var value = _addressService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletrAddress(int id)
        {
            _addressService.TDelete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateAddress(CreateAddressDto createAddressDto)
        {
            var mappedValues = _mapper.Map<Address>(createAddressDto);
            _addressService.TCreate(mappedValues);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAddress(UpdateAddressDto updateAddressDto)
        {
            var mappedValues = _mapper.Map<Address>(updateAddressDto);
            _addressService.TUpdate(mappedValues);


            return Ok();
        }
    }
}
