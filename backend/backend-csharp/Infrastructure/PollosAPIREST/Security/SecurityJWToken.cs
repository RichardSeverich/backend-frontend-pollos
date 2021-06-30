using Microsoft.Extensions.Options;
using PollosAPIREST.Dto;
using PollosAPIREST.Settings;

namespace PollosAPIREST.Security
{
    public class SecurityJWToken
    {
        private readonly AppSettings _appSettings;

        public SecurityJWToken(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        internal DtoUserAuth AddToken(DtoUserAuth user)
        {
            user.Token = SecurityCreateJWT.CreateToken(user, _appSettings);
            return user;
        }
    }
}
