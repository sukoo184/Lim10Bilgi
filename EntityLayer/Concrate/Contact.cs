using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(50)]
        public String UserName { get; set; }

        [StringLength(20)]
        public String UserMail { get; set; }

        [StringLength(50)]
        public String Subjact { get; set; }
        public String Message { get; set; }
       
    }
}
