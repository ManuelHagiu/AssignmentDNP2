using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;


namespace AssignmentDNP2.Data

{
    public class AdultService : IAdultService
    {
        IList<Adult> Adults { get; set; }
        public async Task<IList<Adult>> GetAdultsAsync()
        {

            List<Adult> adults;


            FileContext file = new FileContext();
            {
                adults = file.Adults.ToList();
                file.SaveChanges();
            }
            return adults;
        }
    }
}