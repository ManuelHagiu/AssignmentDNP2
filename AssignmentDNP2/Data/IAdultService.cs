using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace AssignmentDNP2.Data
{
    public interface IAdultService
    {
        public Task<IList<Adult>> GetAdultsAsync();
    }
}