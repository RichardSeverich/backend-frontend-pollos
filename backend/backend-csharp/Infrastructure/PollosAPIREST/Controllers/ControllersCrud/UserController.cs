using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosApplication.Src.UseCases.UseCaseCrud;
using PollosCore.Src.Encrypt;
using System.Collections.Generic;
using System.Linq;

namespace PollosAPIREST.Controllers.ControllersCrud
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly UseCaseCrudUser _useCaseUser;

        public UserController(UseCaseCrudUser useCase)
        {
            _useCaseUser = useCase;
        }

        [HttpGet]
        public IEnumerable<DtoUser> GetAll()
        {
            return _useCaseUser.Read().Select(domainEntity => DtoUser.DomainEntityToDto(domainEntity));
        }

        [HttpPost]
        public string Post([FromBody] DtoUser dtoUser)
        {
            dtoUser.Password = EncryptSha256.Encrypt(dtoUser.Password);
            _useCaseUser.Create(dtoUser.DtoToDomainEntity());
            return "Created";
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody] DtoUser dtoUser)
        {
            dtoUser.Password = EncryptSha256.Encrypt(dtoUser.Password);
            _useCaseUser.Update(id, dtoUser.DtoToDomainEntity());
            return "Updated";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _useCaseUser.Delete(id);
            return "Deleted";
        }
    }
}
