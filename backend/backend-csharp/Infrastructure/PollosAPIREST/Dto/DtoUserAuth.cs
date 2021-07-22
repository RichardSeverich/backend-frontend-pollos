using System.ComponentModel.DataAnnotations;

namespace PollosAPIREST.Dto
{
    public class DtoUserAuth
    {
        [Required]
        [MaxLength(20), MinLength(5)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20), MinLength(5)]
        public string Password { get; set; }

        public string Token { get; set; }
    }
}
