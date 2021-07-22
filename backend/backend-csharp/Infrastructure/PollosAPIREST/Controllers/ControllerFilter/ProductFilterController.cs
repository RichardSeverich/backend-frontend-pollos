using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosAPIREST.Utils;
using PollosApplication.Src.UseCases.UseCaseFilter;
using System.Collections.Generic;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllerFilter
{
    [Authorize]
    [ApiController]
    [Route("/product/filter")]
    public class ProductFilterController
    {
        private readonly UseCaseFilterProduct _useCaseFilter;

        public ProductFilterController(UseCaseFilterProduct useCase)
        {
            _useCaseFilter = useCase;
        }

        [HttpPost]
        public IActionResult Filter([FromBody] DtoFilter dtoFilter)
        {
            List<string> list = new List<string>();
            if (dtoFilter.FilterList != null)
            {
                list = dtoFilter.FilterList.Where(data => (data.Contains("=")
                                        && FilterListValidator<DtoProduct>.Validate(data))).ToList();
            }

            if (list.Count > 0)
            {
                return new OkObjectResult(_useCaseFilter.Filter(list)
                    .Select(domainEntity =>
                    DtoProduct.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
