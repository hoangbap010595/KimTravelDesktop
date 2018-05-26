namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarType")]
    public partial class CarType
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        public bool? Enable { get; set; }
    }
}
