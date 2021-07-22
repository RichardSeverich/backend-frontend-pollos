using PollosCore.Src.DomainEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollosDatabase.Src.DbEntities
{
    [Table("users")]
    public class DbEntityUser : DbEntity
    {
        // getters and setters using by Dapper
        public string Dni { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public DomainEntityUser DbEntityToDomainEntity()
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
                UpdateDate = UpdateDate
            };
        }

        public static DbEntityUser DomainEntityToDbEntity(DomainEntityUser domainEntity)
        {
            return new DbEntityUser
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
