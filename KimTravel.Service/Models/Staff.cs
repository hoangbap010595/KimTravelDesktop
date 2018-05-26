namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public int? PartnerID { get; set; }

        public int? Status { get; set; }

        public int? Kind { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [Required]
        [StringLength(10)]
        public string PSID { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
