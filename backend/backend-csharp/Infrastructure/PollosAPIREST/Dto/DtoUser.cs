using PollosCore.Src.DomainEntities;
using System.ComponentModel.DataAnnotations;

namespace PollosAPIREST.Dto
{
    public class DtoUser : DtoAbstract
    {
        [Required]
        [MaxLength(10), MinLength(4)]
        [RegularExpression("^[0-9]+$")]
        public string Dni { get; set; }

        [Required]
        [MaxLength(20), MinLength(3)]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20), MinLength(3)]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Lastname { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$")]
        public string BirthDate { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [MaxLength(8), MinLength(8)]
        [RegularExpression("^[0-9]+$")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20), MinLength(5)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20), MinLength(5)]
        public string Password { get; set; }

        public DomainEntityUser DtoToDomainEntity()
        {
            return new DomainEntityUser
            {
                Id = Id,
                Dni = Dni,
                Name = Name,
                Lastname = Lastname,
                BirthDate = BirthDate,
                Address = Address,
                PhoneNumber = PhoneNumber,
                Email = Email,
                Username = Username,
                Password = Password,
                CreatedBy = CreatedBy,
                UpdatedBy = UpdatedBy,
                CreationDate = CreationDate,
                UpdateDate = UpdateDate,
            };
        }

        public static DtoUser DomainEntityToDto(DomainEntityUser domainEntity)
        {
            return new DtoUser
            {
                Id = domainEntity.Id,
                Dni = domainEntity.Dni,
                Name = domainEntity.Name,
                Lastname = domainEntity.Lastname,
                BirthDate = domainEntity.BirthDate,
                Address = domainEntity.Address,
                PhoneNumber = domainEntity.PhoneNumber,
                Email = domainEntity.Email,
                Username = domainEntity.Username,
                Password = domainEntity.Password,
                CreatedBy = domainEntity.CreatedBy,
                UpdatedBy = domainEntity.UpdatedBy,
                CreationDate = domainEntity.CreationDate,
                UpdateDate = domainEntity.UpdateDate,
            };
        }
    }
}
