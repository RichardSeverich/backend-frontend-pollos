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
    [Route("/user/pagination-sorting")]
    public class UserPaginationSortingController
    {
        private readonly UseCasePaginationSortingUser _useCasePagSort;

        public UserPaginationSortingController(UseCasePaginationSortingUser useCase)
        {
            _useCasePagSort = useCase;
        }

        [HttpPost]
        public IActionResult PaginateSorting([FromBody] DtoPaginationAndSorting dto)
        {
            bool isSortingListValid = true;

            if (dto.SortingList != null)
            {
                isSortingListValid = SortingListValidator<DtoUser>.Validate(dto.SortingList);
            }

            if (isSortingListValid)
            {
                return new OkObjectResult(_useCasePagSort
                    .PaginateSorting(dto.PageNumber, dto.TotalPageNumber, dto.SortingList)
                    .Select(domainEntity => DtoUser.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
