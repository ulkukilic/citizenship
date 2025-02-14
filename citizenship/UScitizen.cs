using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizenship
{
    internal class USCitizen
    {
        public long PassportNo { get; set; }
        public string NameSurname { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime sistemkayit { get; set; }

        public USCitizen()
        {
               sistemkayit = DateTime.Now;
        }

        public string Legal()
        {
            int age = CalculateAge(Birthdate);
            if (age >= 18)
            {
                return "Successful";

            }
            else
            {
                return "Veli izni gerekli";
            }
        }
            
        private int CalculateAge(DateTime birthdate) 
        {
            int age = DateTime.Today.Year - birthdate.Year;
            if (DateTime.Today.DayOfYear < birthdate.DayOfYear) 
            {
                age--;
            }
            return age;
        }
    }
}
