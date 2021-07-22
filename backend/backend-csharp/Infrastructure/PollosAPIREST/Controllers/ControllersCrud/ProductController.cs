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
    public class ProductController
    {
        private readonly UseCaseCrudProduct _useCaseProduct;

        public ProductController(UseCaseCrudProduct useCase)
        {
            _useCaseProduct = useCase;
        }

        [HttpGet]
        public IEnumerable<DtoProduct> GetAll()
        {
            return _useCaseProduct.Read().Select(domainEntity => DtoProduct.DomainEntityToDto(domainEntity));
        }

        [HttpPost]
        public string Post([FromBody] DtoProduct dtoProduct)
        {
            _useCaseProduct.Create(dtoProduct.DtoToDomainEntity());
            return "Created";
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody] DtoProduct dtoProduct)
        {
            _useCaseProduct.Update(id, dtoProduct.DtoToDomainEntity());
            return "Updated";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _useCaseProduct.Delete(id);
            return "Deleted";
        }
    }
}
