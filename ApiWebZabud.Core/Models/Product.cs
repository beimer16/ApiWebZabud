using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Models
{
    public class Product
    {
      
        public long Id { get; set; }
        
        [Required(ErrorMessage = "This Field {0} is Required")]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "This Field {0} is Required")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "This Field {0} is Required")]
        public int Iva { get; set; }

        [Required(ErrorMessage = "This Field {0} is Required")]
        public decimal IvaValue { get; set; }
    }
}
