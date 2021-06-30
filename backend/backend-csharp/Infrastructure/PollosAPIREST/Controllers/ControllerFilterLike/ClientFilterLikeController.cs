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
    [Route("/client/filter-like")]
    public class ClientFilterLikeController
    {
        private readonly UseCaseFilterLikeClient _useCaseFilterLike;

        public ClientFilterLikeController(UseCaseFilterLikeClient useCase)
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
                                        && FilterListValidator<DtoClient>.Validate(data))).ToList();
            }

            if (list.Count > 0)
            {
                return new OkObjectResult(_useCaseFilterLike
                    .FilterLike(list)
                    .Select(domainEntity =>
                    DtoClient.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
