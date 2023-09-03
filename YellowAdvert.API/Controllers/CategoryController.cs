using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YellowAdvert.API.Dtos.Category.Response;
using YellowAdvert.API.Dtos.Request;
using YellowAdvert.Business.Args;
using YellowAdvert.Cqrs.Command;
using YellowAdvert.Cqrs.Query;
using YellowAdvert.Entities.Models;

namespace YellowAdvert.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoryController(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<CategoryResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery]GetAllCategoriesRequest request,CancellationToken cancellationToken = default)
        {
            var mappedRequest = _mapper.Map<GetAllCategoriesQuery>(request);
            var entity = await _mediator.Send(mappedRequest, cancellationToken);
            if (entity == null)
                return NotFound();
            var result = _mapper.Map<List<CategoryResponse>>(entity);
            return Ok(result);
            
        }
        [HttpGet("GetById")]
        [ProducesResponseType(typeof(CategoryResponse), StatusCodes.Status200OK)]

        public async Task<IActionResult> GetById([FromQuery]GetCategoryByIdRequest request,CancellationToken cancellationToken = default)
        {
            var mappedRequest = _mapper.Map<GetCategoryByIdQuery>(request);
            var entity = await _mediator.Send(mappedRequest, cancellationToken);
            if (entity == null)
                NotFound();
            var result = _mapper.Map<CategoryResponse>(entity);
            return Ok(result);
        }
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                var mappedRequest = _mapper.Map<CreateCategoryCommand>(request);
                var entity = (Category)await _mediator.Send(mappedRequest, cancellationToken);
                if (entity == null)
                    NotFound();
                return Ok(entity.Id);
            }
            catch (Exception ex)
            {

                return Ok();
            }
        }
    }
}
