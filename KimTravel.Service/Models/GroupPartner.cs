namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupPartner")]
    public partial class GroupPartner
    {
        public int GroupPartnerID { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }
    }
}
