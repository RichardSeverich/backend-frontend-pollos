using PollosCore.Src.DomainEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace PollosAPIREST.Dto
{
    public class DtoProduct : DtoAbstract
    {
        [Required]
        [MaxLength(30), MinLength(4)]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string ProductName { get; set; }

        [Required]
        [Range(10, 200)]
        [RegularExpression("^[0-9]+$")]
        public int ProductPrice { get; set; }

        [Required]
        [RegularExpression("^[0-9]+$")]
        [Range(30, 200)]
        public int Stock { get; set; }

        public DomainEntityProduct DtoToDomainEntity()
        {
            return new DomainEntityProduct
            {
                Id = Id,
                ProductName = ProductName,
                ProductPrice = ProductPrice,
                Stock = Stock,
                CreatedBy = CreatedBy,
                UpdatedBy = UpdatedBy,
                CreationDate = CreationDate,
                UpdateDate = UpdateDate,
            };
        }

        public static DtoProduct DomainEntityToDto(DomainEntityProduct domainEntity)
        {
            return new DtoProduct
            {
                Id = domainEntity.Id,
                ProductName = domainEntity.ProductName,
                ProductPrice = domainEntity.ProductPrice,
                Stock = domainEntity.Stock,
                CreatedBy = domainEntity.CreatedBy,
                UpdatedBy = domainEntity.UpdatedBy,
                CreationDate = domainEntity.CreationDate,
                UpdateDate = domainEntity.UpdateDate,
            };
        }
    }
}
