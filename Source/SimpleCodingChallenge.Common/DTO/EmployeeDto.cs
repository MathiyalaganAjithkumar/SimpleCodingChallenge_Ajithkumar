using System.ComponentModel.DataAnnotations;

namespace SimpleCodingChallenge.Common.DTO
{
    public class EmployeeDto
    {
     
        public string EmployeeID { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string Address { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }

        public string country { get; set; }
      



    }
}
