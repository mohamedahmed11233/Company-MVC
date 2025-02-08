using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.DAL.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code id Required !!")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name id Required !!")]

        public string Name { get; set; }
        [DisplayName("Data Fo Creathion")]
        public DateTime DateOfCreathion { get; set; }

    }
}
