namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceType")]
    public partial class ServiceType
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Price { get; set; }

        public int? TourID { get; set; }
    }
}
