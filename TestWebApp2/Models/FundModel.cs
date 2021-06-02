using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp2.Models
{
    public class FundModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Boutique { get; set; }

        [Required]
        public string Category { get; set; }

        public List<string> Shareclasses { get; set; }

        [Required]
        public string ISIN { get; set; }

        [Required]
        public int Valor { get; set; }

        [Required]
        public string Sedol { get; set; }

        [Required]
        public decimal Nav { get; set; }

        [Required]
        public decimal PerformanceYTD { get; set; }

        public string KeyFact { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PublishedDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime UpdateDate { get; set; }
    }
}
