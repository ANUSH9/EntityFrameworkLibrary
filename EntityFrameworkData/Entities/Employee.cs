using EntityFrameworkData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkData.Entities
{
    public class Employee
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }



        public ICollection<EmployeeEducation>? EducationList { get; set; }
    }
}
