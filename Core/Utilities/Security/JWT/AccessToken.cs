using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public List<OperationClaim> Claims { get; set; }

    }
}
