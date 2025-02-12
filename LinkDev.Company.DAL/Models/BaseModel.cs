using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.DAL.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name id Required !!")]

        public string Name { get; set; }
    }
}
