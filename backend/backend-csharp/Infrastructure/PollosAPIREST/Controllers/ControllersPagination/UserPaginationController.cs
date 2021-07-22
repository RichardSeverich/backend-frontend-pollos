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
    [Route("/user/pagination")]
    public class UserPaginationController
    {
        private readonly UseCasePaginationUser _useCasePag;

        public UserPaginationController(UseCasePaginationUser useCase)
        {
            _useCasePag = useCase;
        }

        [HttpPost]
        public IEnumerable<DtoUser> Paginate([FromBody] DtoPagination dto)
        {
            var list = _useCasePag.Paginate(dto.PageNumber, dto.TotalPageNumber);
            return list.Select(domainEntity => DtoUser.DomainEntityToDto(domainEntity));
        }
    }
}
