using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp2.Models;

namespace TestWebApp2.Repository
{
    public interface IFundRepository
    {
        List<FundModel> GetFunds();

        void CreateFund(FundModel fundModel);
    }
}
