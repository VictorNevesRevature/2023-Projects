using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Repo
{
    public interface IRepoAdminPendingClaims
    {
        List<ModelClaimHealth> AdminPendingClaims();
        
    }
}