using System.Collections.Generic;

namespace PollosAPIREST.Dto
{
    public class DtoPaginationAndSorting : DtoPagination
    {
        public List<string> SortingList { get; set; }
    }
}
