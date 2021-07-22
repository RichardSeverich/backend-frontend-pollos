using Microsoft.AspNetCore.Mvc;
using PollosAPIREST.Dto;
using PollosApplication.Src.UseCases;
using PollosCore.Src.DomainEntities;
using PollosAPIREST.Security;
using PollosCore.Src.Encrypt;

namespace PollosAPIREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController
    {
        private readonly UseCaseLogin _useCaseLogin;
        private readonly SecurityJWToken _jwt;

        public LoginController(UseCaseLogin useCase, SecurityJWToken jwt)
        {
            _useCaseLogin = useCase;
            _jwt = jwt;
        }

        [HttpPost]
        public IActionResult Login([FromBody] DtoUserAuth userAuth)
        {
            DomainEntityUser domainEntity = _useCaseLogin.FindUserForLogin(userAuth.Username, EncryptSha256.Encrypt(userAuth.Password));
            if (domainEntity != null)
            {
                _jwt.AddToken(userAuth);
                return new OkObjectResult(userAuth);
            }
            return new BadRequestResult();
        }
    }
}
