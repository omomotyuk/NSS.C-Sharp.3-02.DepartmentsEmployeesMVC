using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentEmployeeMVC.Models
{
    public class Employee
    {
        public int Id { set; get; }

        [Display(Name = "First Name")]
        [Required]
        [MaxLength(15, ErrorMessage = "first name ")]
        public string FirstName { set; get; }
        [Display(Name = "Last Name")]
        public string LastName { set; get; }

        [Display(Name = "Department Id")]
        public int DepartmentId { set; get; }

        public Department Department { set; get; }
    }

}
