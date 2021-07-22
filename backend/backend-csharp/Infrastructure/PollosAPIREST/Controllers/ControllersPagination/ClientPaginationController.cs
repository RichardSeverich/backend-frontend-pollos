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
    [Route("/client/pagination")]
    public class ClientPaginationController
    {
        private readonly UseCasePaginationClient _useCasePag;

        public ClientPaginationController(UseCasePaginationClient useCase)
        {
            _useCasePag = useCase;
        }

        [HttpPost]
        public IEnumerable<DtoClient> Paginate([FromBody] DtoPagination dto)
        {
            var list = _useCasePag.Paginate(dto.PageNumber, dto.TotalPageNumber);
            return list.Select(domainEntity => DtoClient.DomainEntityToDto(domainEntity));
        }
    }
}
