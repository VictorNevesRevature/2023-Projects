using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
    public class GettingEmployeeInfo : IGettingEmployeeInfo
    {

        private readonly IRepoGettingEmployeeInfo irepogettinginfo;
        public GettingEmployeeInfo(IRepoGettingEmployeeInfo irepoinfo)
        {
            irepogettinginfo= irepoinfo;

        }
        public List<Employee> BusGettingEmployeeInfo()
        {
            return irepogettinginfo.GettingEmployeeInfo();

        }
        
    }
}