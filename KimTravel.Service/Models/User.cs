using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KimTravel.Service.Models
{
    [Table("ApplicationUser")]
    public class User
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string Username { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        public string Email { get; set; }

        [StringLength(128)]
        public string Phone { get; set; }

        public bool? ConfirmMail { get; set; }
        public bool? ConfirmPhone { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? Locked { get; set; }
        public DateTime? LockDate { get; set; }
        public int? Status { get; set; }
        public DateTime? LastUpdate { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; }
        
    }

}