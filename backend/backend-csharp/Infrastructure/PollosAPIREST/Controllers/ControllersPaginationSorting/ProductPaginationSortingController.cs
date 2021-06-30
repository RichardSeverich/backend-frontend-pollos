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
    [Route("/product/pagination-sorting")]
    public class ProductPaginationSortingController
    {
        private readonly UseCasePaginationSortingProduct _useCasePagSort;

        public ProductPaginationSortingController(UseCasePaginationSortingProduct useCase)
        {
            _useCasePagSort = useCase;
        }

        [HttpPost]
        public IActionResult PaginateSorting([FromBody] DtoPaginationAndSorting dto)
        {
            bool isSortingListValid = true;

            if (dto.SortingList != null)
            {
                isSortingListValid = SortingListValidator<DtoProduct>.Validate(dto.SortingList);
            }

            if (isSortingListValid)
            {
                return new OkObjectResult(_useCasePagSort
                    .PaginateSorting(dto.PageNumber, dto.TotalPageNumber, dto.SortingList)
                    .Select(domainEntity => DtoProduct.DomainEntityToDto(domainEntity)));
            }
            return new BadRequestResult();
        }
    }
}
