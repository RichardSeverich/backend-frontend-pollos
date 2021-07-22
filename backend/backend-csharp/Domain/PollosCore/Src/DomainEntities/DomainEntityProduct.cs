namespace PollosCore.Src.DomainEntities
{
    public class DomainEntityProduct : DomainEntity
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Stock { get; set; }
    }
}
