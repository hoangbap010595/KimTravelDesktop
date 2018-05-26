namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organization")]
    public partial class Organization
    {
        public int OrganizationID { get; set; }

        [StringLength(50)]
        public string OrganizationName { get; set; }

        [StringLength(32)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(32)]
        public string Email { get; set; }

        [StringLength(256)]
        public string Website { get; set; }

        public int? Status { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(32)]
        public string CreateBy { get; set; }
    }
}
