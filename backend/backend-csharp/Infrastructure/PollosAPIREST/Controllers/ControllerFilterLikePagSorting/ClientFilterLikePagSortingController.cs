using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosAPIREST.Utils;
using PollosApplication.Src.UseCases.UseCaseFilterSorting;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllerFilterLikePagSorting
{
    [Authorize]
    [ApiController]
    [Route("/client/filter-like/pagination-sorting")]
    public class ClientFilterLikePagSortingController
    {
        private readonly UseCaseFilterLikePagSortingClient _useCaseFilterLike;

        public ClientFilterLikePagSortingController(UseCaseFilterLikePagSortingClient useCase)
        {
            _useCaseFilterLike = useCase;
        }

        [HttpPost]
        public IActionResult Filter([FromBody] DtoFilterPaginationSorting dto)
        {
            bool isValid = false;
            if (dto.SortingList != null && dto.FilterList != null)
            {
                isValid = dto.FilterList.All(data => data.Contains("=")
                    && FilterListValidator<DtoClient>.Validate(data)
                    && SortingListValidator<DtoClient>.Validate(dto.SortingList));
            }

            if (isValid)
            {
                var list = _useCaseFilterLike.FilterSorting(dto.PageNumber, dto.TotalPageNumber, 
                    dto.FilterList, dto.SortingList);

                return new OkObjectResult(list.Select(domainEntity =>
                    DtoClient.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
