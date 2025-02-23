using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.DAL.Models
{
    public class Department:BaseModel
    {
        [Required(ErrorMessage = "Code id Required !!")]
        public string Code { get; set; }

        [DisplayName("Date Of Creation")]
        public DateTime DateOfCreathion { get; set; }

        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();



    }
}
