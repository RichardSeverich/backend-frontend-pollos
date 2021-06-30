using System.ComponentModel.DataAnnotations;

namespace PollosAPIREST.Dto
{
    public class DtoPagination
    {
        [Required]
        [RegularExpression("^[0-9]+$")]
        public string PageNumber { get; set; }

        [Required]
        [RegularExpression("^[0-9]+$")]
        public string TotalPageNumber { get; set; }
    }
}
