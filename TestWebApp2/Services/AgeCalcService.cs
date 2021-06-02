using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApp2.Services
{
    public class AgeCalcService
    {
        public DateTime CalcBirthDateFromAge(int age)
        {
            var currentDate = DateTime.Now;
            return currentDate.AddYears(age * (-1)); 
        }
    }
}
