using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosAPIREST.Utils;
using PollosApplication.Src.UseCases.UseCasePaginationSorting;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllersPaginationSorting
{
    [Authorize]
    [ApiController]
    [Route("/client/pagination-sorting")]
    public class ClientPaginationSortingController
    {
        private readonly UseCasePaginationSortingClient _useCasePagSort;

        public ClientPaginationSortingController(UseCasePaginationSortingClient useCase)
        {
            _useCasePagSort = useCase;
        }

        [HttpPost]
        public IActionResult PaginateSorting([FromBody] DtoPaginationAndSorting dto)
        {
            bool isSortingListValid = true;

            if (dto.SortingList != null)
            {
                isSortingListValid = SortingListValidator<DtoClient>.Validate(dto.SortingList);
            }

            if (isSortingListValid)
            {
                return new OkObjectResult(_useCasePagSort
                    .PaginateSorting(dto.PageNumber, dto.TotalPageNumber, dto.SortingList)
                    .Select(domainEntity => DtoClient.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
