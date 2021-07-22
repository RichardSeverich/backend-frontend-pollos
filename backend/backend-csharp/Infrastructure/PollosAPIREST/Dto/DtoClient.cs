using PollosCore.Src.DomainEntities;
using System.ComponentModel.DataAnnotations;

namespace PollosAPIREST.Dto
{
    public class DtoClient : DtoAbstract
    {
        [Required]
        [MaxLength(10), MinLength(4)]
        [RegularExpression("^[0-9]+$")]
        public string Dni { get; set; }

        [Required]
        [MaxLength(20), MinLength(3)]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Name { get; set; }

        public DomainEntityClient DtoToDomainEntity()
        {
            return new DomainEntityClient
            {
                Id = Id,
                Dni = Dni,
                Name = Name,
                CreatedBy = CreatedBy,
                UpdatedBy = UpdatedBy,
                CreationDate = CreationDate,
                UpdateDate = UpdateDate,
            };
        }

        public static DtoClient DomainEntityToDto(DomainEntityClient domainEntity)
        {
            return new DtoClient
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
