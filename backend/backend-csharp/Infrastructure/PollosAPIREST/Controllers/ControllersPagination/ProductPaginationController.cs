using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosApplication.Src.UseCases.UseCasePagination;
using System.Collections.Generic;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllersPagination
{
    [Authorize]
    [ApiController]
    [Route("/product/pagination")]
    public class ProductPaginationController
    {
        private readonly UseCasePaginationProduct _useCasePag;

        public ProductPaginationController(UseCasePaginationProduct useCase)
        {
            _useCasePag = useCase;
        }

        [HttpPost]
        public IEnumerable<DtoProduct> Paginate([FromBody] DtoPagination dto)
        {
            var list = _useCasePag.Paginate(dto.PageNumber, dto.TotalPageNumber);
            return list.Select(domainEntity => DtoProduct.DomainEntityToDto(domainEntity));
        }
    }
}
