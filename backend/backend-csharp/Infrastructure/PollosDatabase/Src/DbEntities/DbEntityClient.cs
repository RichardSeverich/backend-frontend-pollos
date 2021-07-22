using PollosCore.Src.DomainEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollosDatabase.Src.DbEntities
{
    [Table("clients")]
    public class DbEntityClient : DbEntity
    {
        public string Dni { get; set; }
        public string Name { get; set; }

        public DomainEntityClient DbEntityToDomainEntity()
        {
            return new DomainEntityClient
            {
                Id = Id,
                Dni = Dni,
                Name = Name,
                CreatedBy = CreatedBy,
                UpdatedBy = UpdatedBy,
                CreationDate = CreationDate,
                UpdateDate = UpdateDate
            };
        }

        public static DbEntityClient DomainEntityToDbEntity(DomainEntityClient domainEntity)
        {
            return new DbEntityClient
            {
                Id = domainEntity.Id,
                Dni = domainEntity.Dni,
                Name = domainEntity.Name,
                CreatedBy = domainEntity.CreatedBy,
                UpdatedBy = domainEntity.UpdatedBy,
                CreationDate = domainEntity.CreationDate,
                UpdateDate = domainEntity.UpdateDate,
            };
        }
    }
}
