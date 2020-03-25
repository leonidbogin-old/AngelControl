using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Data.Class {
    public class Reg {
        public int Id { get; set; }
        public string Numcard { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Pname { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public int StayWhereId { get; set; }
        public string StayWhere { get; set; }
        public int StayLengthId { get; set; }
        public string StayLength { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int NutritionId { get; set; }
        public string Nutrition { get; set; }



        public static int? GetAge(DateTime? bithday) {
            if (bithday.HasValue) {
                DateTime now = DateTime.Today;
                int age = now.Year - bithday.Value.Year;
                if (bithday > now.AddYears(-age)) age--;
                return age;
            } else {
                return (int?)null;
            }
                
        }
    }
}
