using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Models
{
    public class Client
    {
              
        public long Id { get; set; }

        [MaxLength(70)]
        [Required(ErrorMessage = "This Field {0} is Required")]
        public string Name { get; set; }

        [MaxLength(90)]
        [Required(ErrorMessage = "This Field {0} is Required")]
        public string LastName { get; set; }

        [MaxLength(150)]
        [Required(ErrorMessage = "This Field {0} is Required")]
        public string Address { get; set; }

        [MaxLength(11)]
        public string Telephone { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "This Field {0} is Required")]
        public string Cellphone { get; set; }

        [MaxLength(15)]

        public string Identification { get; set; }

        [MaxLength(18)]
        public string Nit { get; set; }
    }
}
