using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepoLayer;

namespace BusinessLayer
{
    public class BusLoginEmployee
    {
        private readonly IRepoLoginEmployee? repo;

        public BusLoginEmployee(IRepoLoginEmployee iRepo)
        {
        repo = iRepo;
        }

        

        
    
}
}