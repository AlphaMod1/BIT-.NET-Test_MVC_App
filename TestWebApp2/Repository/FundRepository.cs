using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp2.Models;

namespace TestWebApp2.Repository
{
    public class FundRepository : IFundRepository
    {
        private readonly List<FundModel> _fundRepository;

        public FundRepository()
        {
            _fundRepository = new List<FundModel>()
            {
                new FundModel()
                {
                    Id = 0,
                    Name = "Fund - Global Equity",
                    Boutique = "Quality Growth Boutique",
                    Category = "Global Equities",
                    Shareclasses = new List<string>()
                    {
                        "I USD", "I GBP", "A USD", "AI EUR"
                    },
                    ISIN = "LU0278093595",
                    Valor = 2870708,
                    Sedol = "B86VGC6",
                    Nav = 284.05M,
                    PerformanceYTD = 10.22M,
                    KeyFact = "MS4.svg",
                    PublishedDate = new DateTime(2016 / 12 / 19),
                    UpdateDate = new DateTime(2020 / 09 / 30)
                },
                 new FundModel()
                {
                    Id = 1,
                    Name = "Fund - Global Corporate Bond Mid Yield",
                    Boutique = "Fixed Income Boutique",
                    Category = "Corporate Bonds",
                    Shareclasses = new List<string>()
                    {
                        "I USD", "I GBP", "A USD", "AI EUR"
                    },
                    ISIN = "LU1395537134",
                    Valor = 32261851,
                    Sedol = "T78VHR7",
                    Nav = 130.07M,
                    PerformanceYTD = 6.21M,
                    KeyFact = "MS4.svg",
                    PublishedDate = new DateTime(2019 / 07 / 15),
                    UpdateDate = new DateTime(2020 / 01 / 30)
                }
            };
        }

        public void CreateFund(FundModel fundModel)
        {
            _fundRepository.Add(fundModel);
        }

        public List<FundModel> GetFunds()
        {
            return _fundRepository;
        }
    }
}
