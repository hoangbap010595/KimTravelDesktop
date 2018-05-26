namespace KimTravel.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int CarID { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        public int? Type { get; set; }

        public int? Max { get; set; }

        public int? StaffID { get; set; }

        [StringLength(50)]
        public string Note { get; set; }
    }
}
