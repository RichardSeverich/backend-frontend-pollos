using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosAPIREST.Utils;
using PollosApplication.Src.UseCases.UseCaseFilterLike;
using System.Collections.Generic;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllerFilterLike
{
    [Authorize]
    [ApiController]
    [Route("/user/filter-like")]
    public class UserFilterLikeController
    {
        private readonly UseCaseFilterLikeUser _useCaseFilterLike;

        public UserFilterLikeController(UseCaseFilterLikeUser useCase)
        {
            _useCaseFilterLike = useCase;
        }

        [HttpPost]
        public IActionResult Filter([FromBody] DtoFilter dtoFilter)
        {
            List<string> list = new List<string>();
            if (dtoFilter.FilterList != null)
            {
                list = dtoFilter.FilterList.Where(data => (data.Contains("=")
                                        && FilterListValidator<DtoUser>.Validate(data))).ToList();
            }

            if (list.Count > 0)
            {
                return new OkObjectResult(_useCaseFilterLike
                    .FilterLike(list)
                    .Select(domainEntity =>
                    DtoUser.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
