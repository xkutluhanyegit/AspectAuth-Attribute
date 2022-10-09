using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}