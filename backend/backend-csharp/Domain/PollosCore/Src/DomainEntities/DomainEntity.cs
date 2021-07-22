namespace PollosCore.Src.DomainEntities
{
    public abstract class DomainEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
