using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControlManagementSoftware.JWT_Bearer_Configuration
{
    public class JWTBearerTokenSetting
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int ExpireTimeInSeconds { get; set; }

    }
}
