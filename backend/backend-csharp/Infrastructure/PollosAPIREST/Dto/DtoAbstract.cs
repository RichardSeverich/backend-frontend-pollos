namespace PollosAPIREST.Dto
{
    public abstract class DtoAbstract
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
