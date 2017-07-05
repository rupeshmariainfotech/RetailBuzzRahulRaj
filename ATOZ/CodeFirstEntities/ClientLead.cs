using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEntities
{
    [Serializable]
    public class ClientLead
    {
        [Key]
        public int clientLeadId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string ClientName { get; set; }
        [Required]
        [Display(Name = "ContactNo1")]    
        [Range(1000000, 99999999999999, ErrorMessage = "Contact No 1 should be between 7 and 14")]
      
        public string ContactNo1 { get; set; }
        [Required]
        [Display(Name = "ContactNo2")]
        [Range(1000000, 99999999999999, ErrorMessage = "Contact No 1 should be between 7 and 14")]

        public string ContactNo2 { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Requriment")]
        public string Requriment { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public DateTime? ScheduleDate { get; set; }
        [Required]
        [Display(Name = "Remark")]
        public string Remark { get; set; }

    }
}
