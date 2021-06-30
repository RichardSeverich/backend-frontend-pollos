using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosApplication.Src.UseCases.UseCaseCrud;
using System.Collections.Generic;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllersCrud
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ClientController
    {
        private readonly UseCaseCrudClient _useCaseClient;

        public ClientController(UseCaseCrudClient useCase)
        {
            _useCaseClient = useCase;
        }

        [HttpGet]
        public IEnumerable<DtoClient> GetAll()
        {
            return _useCaseClient.Read().Select(domainEntity => DtoClient.DomainEntityToDto(domainEntity));
        }

        [HttpPost]
        public string Post([FromBody] DtoClient dtoClient)
        {
            _useCaseClient.Create(dtoClient.DtoToDomainEntity());
            return "Created";
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody] DtoClient dtoClient)
        {
            _useCaseClient.Update(id, dtoClient.DtoToDomainEntity());
            return "Updated";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _useCaseClient.Delete(id);
            return "Deleted";
        }
    }
}
