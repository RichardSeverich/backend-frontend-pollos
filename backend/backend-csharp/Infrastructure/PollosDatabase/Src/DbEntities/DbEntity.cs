using Dapper.Contrib.Extensions;
using PollosCore.Src.DomainEntities;

namespace PollosDatabase.Src.DbEntities
{
    public abstract class DbEntity
    {
        [Key]
        [Write(false)]
        internal int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        [Write(false)]
        public string CreationDate { get; set; }
        [Write(false)]
        public string UpdateDate { get; set; }

        /*
         * TOne Db Entity
         * TTwo Domain Entity
         */
        public TTwo DbEntityToDomainEntity<TOne, TTwo>(TOne dbEntity, TTwo domainEntity)
            where TOne : DbEntity
            where TTwo : DomainEntity
        {
            foreach (var field in typeof(TOne).GetProperties())
            {
                field.SetValue(domainEntity, field.GetValue(dbEntity));
            }

            return domainEntity;
        }

        /*
         * TOne Domain Entity
         * TTwo Db Entity
         */
        public TTwo EntityDomainToDEntity<TOne, TTwo>(TOne domainEntity, TTwo dbEntity)
            where TOne : DomainEntity
            where TTwo : DbEntity
        {
            foreach (var field in typeof(TOne).GetProperties())
            {
                field.SetValue(dbEntity, field.GetValue(domainEntity));
            }

            return dbEntity;
        }
    }
}
