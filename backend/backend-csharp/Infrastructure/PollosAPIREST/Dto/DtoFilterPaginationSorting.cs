using System.Collections.Generic;

namespace PollosAPIREST.Dto
{
    public class DtoFilterPaginationSorting : DtoPaginationAndSorting
    {
        public List<string> FilterList { get; set; }
    }
}
