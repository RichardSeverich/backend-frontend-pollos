using PollosCore.Src.DomainEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollosDatabase.Src.DbEntities
{
    [Table("products")]
    public class DbEntityProduct : DbEntity
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Stock { get; set; }

        public DomainEntityProduct DbEntityToDomainEntity()
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
                UpdateDate = UpdateDate
            };
        }

        public static DbEntityProduct DomainEntityToDbEntity(DomainEntityProduct domainEntity)
        {
            return new DbEntityProduct
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
