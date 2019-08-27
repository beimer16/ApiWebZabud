using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebZabud.Core.Models
{
     public class Shopping
    {
      
         public long Id { get; set; }

        [Required(ErrorMessage = "This Field {0} is Required")]
        public long ClientId { get; set; }


        [Required(ErrorMessage = "This Field {0} is Required")]
        public long ProductId { get; set; }
    }
}
